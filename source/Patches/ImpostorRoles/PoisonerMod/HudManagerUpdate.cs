using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using System.Linq;
using Hazel;
using TownOfUs.Extensions;

namespace TownOfUs.ImpostorRoles.PoisonerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        public static Sprite PoisonSprite => TownOfUs.PoisonSprite;
        public static Sprite PoisonedSprite => TownOfUs.PoisonedSprite;

        [HarmonyPriority(Priority.Last)]
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Poisoner)) return;
            var role = Role.GetRole<Poisoner>(PlayerControl.LocalPlayer);
            if (role.PoisonButton == null)
            {
                role.PoisonButton = Object.Instantiate(__instance.KillButton, __instance.KillButton.transform.parent);
                role.PoisonButton.graphic.enabled = true;
                role.PoisonButton.graphic.sprite = PoisonSprite;
                role.PoisonButton.gameObject.SetActive(false);
            }

            role.PoisonButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            if (!CustomGameOptions.PoisonerCanKill && !PlayerControl.LocalPlayer.Data.IsDead && !MeetingHud.Instance) __instance.KillButton.Hide();
            else if (CustomGameOptions.PoisonerCanKill && !PlayerControl.LocalPlayer.Data.IsDead && !MeetingHud.Instance) __instance.KillButton.Show();
            //if (!PlayerControl.LocalPlayer.Data.IsDead && !MeetingHud.Instance) role.PoisonButton.Show();

            //var position = __instance.KillButton.transform.localPosition;
           // role.PoisonButton.transform.localPosition = new Vector3(__instance.SabotageButton.transform.localPosition.x,
                //__instance.ImpostorVentButton.transform.localPosition.y, position.z);
            var notImp = PlayerControl.AllPlayerControls
                    .ToArray()
                    .Where(x => !x.Is(Faction.Impostors))
                    .ToList();
            Utils.SetTarget(ref role.ClosestPlayer, role.PoisonButton, float.NaN, notImp);

            if (role.ClosestPlayer != null)
            {
                role.ClosestPlayer.myRend().material.SetColor("_OutlineColor", Palette.Purple);
            }

            //role.Player.SetKillTimer(1f);
            try
            {
                if (role.Poisoned)
                {
                    role.PoisonButton.graphic.sprite = PoisonedSprite;
                    role.Poison();
                    role.PoisonButton.SetCoolDown(role.TimeRemaining, CustomGameOptions.PoisonDuration);
                }
                else
                {
                    role.PoisonButton.graphic.sprite = PoisonSprite;
                    if (role.PoisonedPlayer && role.PoisonedPlayer != PlayerControl.LocalPlayer)
                    {
                        role.PoisonKill();
                    }
                    if (role.ClosestPlayer != null)
                    {
                        role.PoisonButton.graphic.color = Palette.EnabledColor;
                        role.PoisonButton.graphic.material.SetFloat("_Desat", 0f);
                    }
                    else
                    {
                        role.PoisonButton.graphic.color = Palette.DisabledClear;
                        role.PoisonButton.graphic.material.SetFloat("_Desat", 1f);
                    }
                    role.PoisonButton.SetCoolDown(role.PoisonTimer(), CustomGameOptions.PoisonCd);
                    role.PoisonedPlayer = PlayerControl.LocalPlayer; //Only do this to stop repeatedly trying to re-kill poisoned player. null didn't work for some reason
                }
            }
            catch
            {

            }
        }
    }
}
