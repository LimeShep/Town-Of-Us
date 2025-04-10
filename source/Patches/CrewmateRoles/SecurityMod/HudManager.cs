using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SecurityMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FixedUpdate))]
    public class HudUpdate
    {
        public static void Postfix(PlayerControl __instance)
        {
            UpdateCamButton(__instance);
        }

        public static void UpdateCamButton(PlayerControl __instance) {
            if (PlayerControl.AllPlayerControls.Count <= 1 || PlayerControl.LocalPlayer?.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Security)) return;
            var camButton = DestroyableSingleton<HudManager>.Instance.KillButton;

            var role = Role.GetRole<Roles.Security>(PlayerControl.LocalPlayer);

            bool canUseButton = !MeetingHud.Instance
                                && !PlayerControl.LocalPlayer.Data.IsDead
                                && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started;

            camButton.gameObject.SetActive(canUseButton);

            if (role.UsesText == null) {
                role.UsesText = Object.Instantiate(camButton.cooldownTimerText, camButton.transform);
                role.UsesText.gameObject.SetActive(true);
                role.UsesText.transform.localPosition += new Vector3(0.26f, 0.29f, 0f);
                role.UsesText.transform.localScale *= 0.65f;
                role.UsesText.alignment = TMPro.TextAlignmentOptions.Right;
                role.UsesText.fontStyle = TMPro.FontStyles.Bold;
            }

            if (role.UsesText != null) {
                role.UsesText.text = role.UsesLeft.ToString();
            }

            var renderer = camButton.graphic;

            if (role.ButtonUsable) {
                renderer.color = Palette.EnabledColor;
                //renderer.material.SetFloat("_Desat", 0f);
                role.UsesText.color = Palette.EnabledColor;
                role.UsesText.material.SetFloat("_Desat", 0f);
            } else {
                renderer.color = Palette.DisabledClear;
                //renderer.material.SetFloat("_Desat", 1f);
                role.UsesText.color = Palette.DisabledClear;
                role.UsesText.material.SetFloat("_Desat", 0f);
            }
        }
    }
}
