using System.Linq;
using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using TownOfUs.Roles.Modifiers;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.EvokerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HudManagerUpdate
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Evoker)) return;
            var isDead = PlayerControl.LocalPlayer.Data.IsDead;
            var evokeButton = __instance.KillButton;
            var role = Role.GetRole<Evoker>(PlayerControl.LocalPlayer);

            evokeButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            evokeButton.SetCoolDown(role.BlindTimer(), CustomGameOptions.EvokerCooldown);

            if (role.Evoked)
            {
                evokeButton.SetCoolDown(role.TimeRemaining, CustomGameOptions.EvokerDuration);
                evokeButton.graphic.color = Palette.EnabledColor;
                evokeButton.graphic.material.SetFloat("_Desat", 0f);

                return;
            }
            else
            {
                evokeButton.SetCoolDown(role.BlindTimer(), CustomGameOptions.EvokerCooldown);

                if (role.BlindTimer() > 0f || !PlayerControl.LocalPlayer.moveable)
                {
                    evokeButton.graphic.color = Palette.DisabledClear;
                    evokeButton.graphic.material.SetFloat("_Desat", 1f);
                }
                else
                {
                    evokeButton.graphic.color = Palette.EnabledColor;
                    evokeButton.graphic.material.SetFloat("_Desat", 0f);
                }

                return;
            }
        }
    }
}