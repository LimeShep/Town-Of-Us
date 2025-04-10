using System.Linq;
using HarmonyLib;
using Innersloth.Assets;
using TownOfUs.CrewmateRoles.SheriffMod;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.NeutralRoles.VampireMod
{
    [HarmonyPatch(typeof(HudManager))]
    public class HudBite
    {
        [HarmonyPatch(nameof(HudManager.Update))]
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Vampire)) return;
            var biteButton = __instance.KillButton;

            var role = Role.GetRole<Vampire>(PlayerControl.LocalPlayer);

            if (!role.KillSprite) role.KillSprite = biteButton.graphic.sprite;

            if (!role.madeASideKick && !role.isSidekick) { biteButton.graphic.sprite = TownOfUs.Sidekick; biteButton.buttonLabelText.text = ""; }
            else biteButton.graphic.sprite = role.KillSprite;

            biteButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            biteButton.SetCoolDown(role.BiteTimer(), CustomGameOptions.BiteCd);

            if (role.LightButton == null)
            {
                role.LightButton = Object.Instantiate(__instance.KillButton, __instance.KillButton.transform.parent);
                if (role.isSidekick) role.LightButton.Hide();
                else role.LightButton.Show();
                role.LightButton.graphic.enabled = true;
                role.LightButton.gameObject.SetActive(false);
            }

            role.LightButton.graphic.sprite = TownOfUs.Light;
            role.LightButton.transform.localPosition = new Vector3(-2f, 0f, 0f);

            role.LightButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);

            role.LightButton.SetCoolDown(role.LightTimer(), CustomGameOptions.LightCd);

            if (role.LightTimer() > 0f || !PlayerControl.LocalPlayer.moveable) {
                role.LightButton.graphic.color = Palette.DisabledClear;
                role.LightButton.graphic.material.SetFloat("_Desat", 1f);
            } else {
                role.LightButton.graphic.color = Palette.EnabledColor;
                role.LightButton.graphic.material.SetFloat("_Desat", 0f);
            }

            var notVampire = PlayerControl.AllPlayerControls
                .ToArray()
                .Where(x => !x.Is(RoleEnum.Vampire))
                .ToList();

            var notVampireOrLover = PlayerControl.AllPlayerControls
                .ToArray()
                .Where(x => !x.Is(RoleEnum.Vampire) && !x.IsLover())
                .ToList();

            if ((CamouflageUnCamouflage.IsCamoed && CustomGameOptions.CamoCommsKillAnyone) || PlayerControl.LocalPlayer.IsHypnotised()) Utils.SetTarget(ref role.ClosestPlayer, biteButton);
            else if (PlayerControl.LocalPlayer.IsLover() && CustomGameOptions.ImpLoverKillTeammate) Utils.SetTarget(ref role.ClosestPlayer, biteButton, float.NaN, PlayerControl.AllPlayerControls.ToArray().Where(x => !x.IsLover()).ToList());
            else if (PlayerControl.LocalPlayer.IsLover()) Utils.SetTarget(ref role.ClosestPlayer, biteButton, float.NaN, notVampireOrLover);
            else Utils.SetTarget(ref role.ClosestPlayer, biteButton, float.NaN, notVampire);
        }
    }
}
