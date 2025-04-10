using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using System.Linq;
using TownOfUs.Extensions;
using AmongUs.GameOptions;
using TownOfUs.CrewmateRoles.TimeLordMod;

namespace TownOfUs.ImpostorRoles.DisorienterMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        public static Sprite Disorient => TownOfUs.DisorientSprite;

        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Disorienter)) return;
            var role = Role.GetRole<Disorienter>(PlayerControl.LocalPlayer);
            if (role.DisorientButton == null)
            {
                role.DisorientButton = Object.Instantiate(__instance.KillButton, __instance.KillButton.transform.parent);
                role.DisorientButton.graphic.enabled = true;
                role.DisorientButton.gameObject.SetActive(false);
            }

            role.DisorientButton.graphic.sprite = Disorient;
            role.DisorientButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);

            var notDisoriented = PlayerControl.AllPlayerControls.ToArray().Where(
                player => role.Disoriented?.PlayerId != player.PlayerId
            ).ToList();

            Utils.SetTarget(ref role.ClosestPlayer, role.DisorientButton, GameOptionsData.KillDistances[GameOptionsManager.Instance.currentNormalGameOptions.KillDistance], notDisoriented);

            role.DisorientButton.SetCoolDown(role.DisorientTimer(), CustomGameOptions.BlackmailCd);

            if (role.Disoriented != null && !role.Disoriented.Data.IsDead && !role.Disoriented.Data.Disconnected)
            {
                role.Disoriented.myRend().material.SetFloat("_Outline", 1f);
                role.Disoriented.myRend().material.SetColor("_OutlineColor", new Color(0.3f, 0.0f, 0.0f));
                if (role.Disoriented.GetCustomOutfitType() != CustomPlayerOutfitType.Camouflage &&
                    role.Disoriented.GetCustomOutfitType() != CustomPlayerOutfitType.Swooper)
                    role.Disoriented.nameText().color = new Color(0.3f, 0.0f, 0.0f);
                else role.Disoriented.nameText().color = Color.clear;
            }

            var imps = PlayerControl.AllPlayerControls.ToArray().Where(
                player => player.Data.IsImpostor() && player != role.Disoriented
            ).ToList();

            foreach (var imp in imps)
            {
                if ((imp.GetCustomOutfitType() == CustomPlayerOutfitType.Camouflage ||
                    imp.GetCustomOutfitType() == CustomPlayerOutfitType.Swooper)) imp.nameText().color = Color.clear;
                else if (imp.nameText().color == Color.clear ||
                    imp.nameText().color == new Color(0.3f, 0.0f, 0.0f)) imp.nameText().color = Patches.Colors.Impostor;
            }
        }
    }
}