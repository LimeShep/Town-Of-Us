using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.ConserverMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.FixedUpdate))]
    public class HudUpdate
    {
        public static void Postfix(PlayerControl __instance)
        {
            UpdateSealButton(__instance);
        }

        public static void SetTargetVent(Conserver role) {
            if (ShipStatus.Instance == null || ShipStatus.Instance.AllVents == null) return;

            Vent target = null;
            Vector2 truePosition = PlayerControl.LocalPlayer.GetTruePosition();
            float closestDistance = float.MaxValue;
            for (int i = 0; i < ShipStatus.Instance.AllVents.Length; i++) {
                Vent vent = ShipStatus.Instance.AllVents[i];
                if (vent.gameObject.name.StartsWith("JackInTheBoxVent_") || vent.gameObject.name.StartsWith("SealedVent_") || vent.gameObject.name.StartsWith("FutureSealedVent_")) continue;
                float distance = Vector2.Distance(vent.transform.position, truePosition);
                if (distance <= vent.UsableDistance && distance < closestDistance) {
                    closestDistance = distance;
                    target = vent;
                }
            }
            role.ClosestVent = target;
        }

        public static void UpdateSealButton(PlayerControl __instance) {
            if (PlayerControl.AllPlayerControls.Count <= 1 || PlayerControl.LocalPlayer?.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Conserver)) return;
            var sealButton = DestroyableSingleton<HudManager>.Instance.KillButton;

            var role = Role.GetRole<Conserver>(PlayerControl.LocalPlayer);

            SetTargetVent(role);

            bool canUseButton = !MeetingHud.Instance
                                && !PlayerControl.LocalPlayer.Data.IsDead
                                && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started;

            sealButton.gameObject.SetActive(canUseButton);

            if (role.UsesText == null) {
                role.UsesText = Object.Instantiate(sealButton.cooldownTimerText, sealButton.transform);
                role.UsesText.gameObject.SetActive(true);
                role.UsesText.transform.localPosition += new Vector3(0.26f, 0.29f, 0f);
                role.UsesText.transform.localScale *= 0.65f;
                role.UsesText.alignment = TMPro.TextAlignmentOptions.Right;
                role.UsesText.fontStyle = TMPro.FontStyles.Bold;
            }

            if (role.UsesText != null) {
                role.UsesText.text = role.UsesLeft.ToString();
            }

            var renderer = sealButton.graphic;
            bool isEnabled = role.ClosestVent != null;

            if (isEnabled && role.ButtonUsable) {
                renderer.color = Palette.EnabledColor;
                renderer.material.SetFloat("_Desat", 0f);
                role.UsesText.color = Palette.EnabledColor;
                role.UsesText.material.SetFloat("_Desat", 0f);
            } else {
                renderer.color = Palette.DisabledClear;
                role.UsesText.color = Palette.DisabledClear;
                role.UsesText.material.SetFloat("_Desat", 0f);
            }
        }
    }
}
