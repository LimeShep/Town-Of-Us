﻿using System;
using HarmonyLib;
using Hazel;
using TownOfUs.Roles;
using UnityEngine;
using Reactor;
using TownOfUs.CrewmateRoles.MedicMod;

namespace TownOfUs.ImpostorRoles.PoisonerMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformPoisonKill
    {
        public static Sprite PoisonSprite => TownOfUs.PoisonSprite;
        public static Sprite PoisonedSprite => TownOfUs.PoisonedSprite;

        public static bool Prefix(KillButton __instance)
        {
            if (__instance == DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            var flag = PlayerControl.LocalPlayer.Is(RoleEnum.Poisoner);
            if (!flag) return true;
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var role = Role.GetRole<Poisoner>(PlayerControl.LocalPlayer);
            var target = role.ClosestPlayer;
            if (target == null) return false;
            if (!__instance.isActiveAndEnabled) return false;
            if (role.PoisonTimer() > 0) return false;
            if (role.Enabled == true) return false;

            role.Player.SetKillTimer(GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown);
            if (role.Player.inVent)
            {
                role.PoisonButton.SetCoolDown(0.01f, 1f);
                return false;
            }
            if (role.ClosestPlayer.Is(RoleEnum.Pestilence))
            {
                if (role.Player.IsShielded())
                {
                    var medic = role.Player.GetMedic().Player.PlayerId;
                    var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                    writer.Write(medic);
                    writer.Write(role.Player.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer);

                    if (CustomGameOptions.ShieldBreaks) role.LastPoisoned = DateTime.UtcNow;
                    role.PoisonButton.SetCoolDown(0.01f, 1f);

                    StopKill.BreakShield(medic, role.Player.PlayerId,
                        CustomGameOptions.ShieldBreaks);
                }
                if (role.Player.IsProtected())
                {
                    role.LastPoisoned.AddSeconds(CustomGameOptions.ProtectKCReset);
                    role.PoisonButton.SetCoolDown(0.01f, 1f);
                    return false;
                }
                Utils.RpcMurderPlayer(role.ClosestPlayer, PlayerControl.LocalPlayer);
                return false;
            }
            if (role.ClosestPlayer.IsInfected() || role.Player.IsInfected())
            {
                foreach (var pb in Role.GetRoles(RoleEnum.Plaguebearer)) ((Plaguebearer)pb).RpcSpreadInfection(role.ClosestPlayer, role.Player);
            }
            if (role.ClosestPlayer.IsOnAlert())
            {
                if (role.ClosestPlayer.IsShielded())
                {
                    var medic = role.ClosestPlayer.GetMedic().Player.PlayerId;
                    var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                    writer.Write(medic);
                    writer.Write(role.ClosestPlayer.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer);

                    if (CustomGameOptions.ShieldBreaks) role.LastPoisoned = DateTime.UtcNow;
                    role.PoisonButton.SetCoolDown(0.01f, 1f);

                    StopKill.BreakShield(medic, role.ClosestPlayer.PlayerId,
                        CustomGameOptions.ShieldBreaks);

                    if (!PlayerControl.LocalPlayer.IsProtected())
                    {
                        Utils.RpcMurderPlayer(role.ClosestPlayer, role.Player);
                    }
                }
                else if (role.Player.IsShielded())
                {
                    var medic = role.Player.GetMedic().Player.PlayerId;
                    var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                    writer.Write(medic);
                    writer.Write(role.Player.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer);

                    if (CustomGameOptions.ShieldBreaks) role.LastPoisoned = DateTime.UtcNow;
                    role.PoisonButton.SetCoolDown(0.01f, 1f);

                    StopKill.BreakShield(medic, role.Player.PlayerId,
                        CustomGameOptions.ShieldBreaks);
                    if (CustomGameOptions.KilledOnAlert && !target.IsProtected())
                    {
                        role.PoisonedPlayer = target;
                        role.PoisonButton.SetTarget(null);
                        DestroyableSingleton<HudManager>.Instance.KillButton.SetTarget(null);

                        role.TimeRemaining = CustomGameOptions.PoisonDuration;
                        role.PoisonButton.SetCoolDown(role.TimeRemaining, CustomGameOptions.PoisonDuration);
                        var writer4 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                            (byte)CustomRPC.Poison,
                        SendOption.Reliable, -1);
                        writer4.Write(PlayerControl.LocalPlayer.PlayerId);
                        writer4.Write(role.PoisonedPlayer.PlayerId);
                        AmongUsClient.Instance.FinishRpcImmediately(writer4);
                    }
                }
                else
                {
                    if (!PlayerControl.LocalPlayer.IsProtected())
                    {
                        Utils.RpcMurderPlayer(role.ClosestPlayer, role.Player);
                    }
                    if (CustomGameOptions.KilledOnAlert && !target.IsProtected())
                    {
                        role.PoisonedPlayer = target;
                        role.PoisonButton.SetTarget(null);
                        DestroyableSingleton<HudManager>.Instance.KillButton.SetTarget(null);
                        role.PoisonButton.SetCoolDown(0.01f, 1f);

                        role.TimeRemaining = CustomGameOptions.PoisonDuration;
                        role.PoisonButton.SetCoolDown(role.TimeRemaining, CustomGameOptions.PoisonDuration);
                        var writer3 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                            (byte)CustomRPC.Poison,
                        SendOption.Reliable, -1);
                        writer3.Write(PlayerControl.LocalPlayer.PlayerId);
                        writer3.Write(role.PoisonedPlayer.PlayerId);
                        AmongUsClient.Instance.FinishRpcImmediately(writer3);
                        // role.Player.SetKillTimer(0);
                    }
                    else
                    {
                        role.LastPoisoned.AddSeconds(CustomGameOptions.ProtectKCReset + 0.01f);
                        role.PoisonButton.SetCoolDown(0.01f, 1f);
                    }
                }
                return false;
            }
            else if (role.ClosestPlayer.IsShielded())
            {
                var medic = role.ClosestPlayer.GetMedic().Player.PlayerId;
                var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                    (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                writer.Write(medic);
                writer.Write(role.ClosestPlayer.PlayerId);
                AmongUsClient.Instance.FinishRpcImmediately(writer);

                if (CustomGameOptions.ShieldBreaks) role.LastPoisoned = DateTime.UtcNow;
                role.PoisonButton.SetCoolDown(0.01f, 1f);

                StopKill.BreakShield(medic, role.ClosestPlayer.PlayerId,
                    CustomGameOptions.ShieldBreaks);

                return false;
            }
            else if (role.ClosestPlayer.IsVesting())
            {
                role.LastPoisoned.AddSeconds(CustomGameOptions.VestKCReset + 0.01f);
                role.PoisonButton.SetCoolDown(0.01f, 1f);
                return false;
            }
            else if (role.ClosestPlayer.IsProtected())
            {
                role.LastPoisoned.AddSeconds(CustomGameOptions.ProtectKCReset + 0.01f);
                role.PoisonButton.SetCoolDown(0.01f, 1f);
                return false;
            }
            role.PoisonedPlayer = target;
            role.PoisonButton.SetTarget(null);
            DestroyableSingleton<HudManager>.Instance.KillButton.SetTarget(null);
            role.TimeRemaining = CustomGameOptions.PoisonDuration;
            role.PoisonButton.SetCoolDown(role.TimeRemaining, CustomGameOptions.PoisonDuration);
            var writer2 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                (byte)CustomRPC.Poison,
            SendOption.Reliable, -1);
            writer2.Write(PlayerControl.LocalPlayer.PlayerId);
            writer2.Write(role.PoisonedPlayer.PlayerId);
            AmongUsClient.Instance.FinishRpcImmediately(writer2);
            // role.Player.SetKillTimer(0);
            return false;
        }
    }
}
