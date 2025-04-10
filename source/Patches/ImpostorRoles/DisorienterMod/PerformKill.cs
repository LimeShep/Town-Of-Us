using HarmonyLib;
using TownOfUs.Roles;
using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.ImpostorRoles.DisorienterMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformKill
    {
        public static bool Prefix(KillButton __instance)
        {
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Disorienter)) return true;
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var role = Role.GetRole<Disorienter>(PlayerControl.LocalPlayer);
            var target = role.ClosestPlayer;
            if (__instance == role.DisorientButton)
            {
                if (!__instance.isActiveAndEnabled || role.ClosestPlayer == null) return false;
                if (__instance.isCoolingDown) return false;
                if (!__instance.isActiveAndEnabled) return false;
                if (role.DisorientTimer() != 0) return false;

                var interact = Utils.Interact(PlayerControl.LocalPlayer, target);
                if (interact[4] == true)
                {
                    role.Disoriented?.myRend().material.SetFloat("_Outline", 0f);
                    if (role.Disoriented != null && role.Disoriented.Data.IsImpostor())
                    {
                        if (role.Disoriented.GetCustomOutfitType() != CustomPlayerOutfitType.Camouflage &&
                            role.Disoriented.GetCustomOutfitType() != CustomPlayerOutfitType.Swooper)
                            role.Disoriented.nameText().color = Patches.Colors.Impostor;
                        else role.Disoriented.nameText().color = Color.clear;
                    }
                    role.Disoriented = target;
                    Utils.Rpc(CustomRPC.Disorient, PlayerControl.LocalPlayer.PlayerId, target.PlayerId);
                    role.LastDisoriented = System.DateTime.UtcNow.AddSeconds(CustomGameOptions.DisorientCd);
                }
                role.DisorientButton.SetCoolDown(0.01f, 1f);
                return false;
            }
            return true;
        }
    }
}