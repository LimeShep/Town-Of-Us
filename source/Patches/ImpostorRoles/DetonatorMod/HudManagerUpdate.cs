using AmongUs.GameOptions;
using HarmonyLib;
using System.Linq;
using TownOfUs.CrewmateRoles.TimeLordMod;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.ImpostorRoles.DetonatorMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        public static Sprite PlantSprite => TownOfUs.PlantSprite;
        public static Sprite DetonateSprite => TownOfUs.DetonateSprite;

        [HarmonyPriority(Priority.Last)]
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Detonator)) return;
            var role = Role.GetRole<Detonator>(PlayerControl.LocalPlayer);
            if (role.PlantButton == null)
            {
                role.PlantButton = Object.Instantiate(__instance.KillButton, __instance.KillButton.transform.parent);
                role.PlantButton.graphic.enabled = true;
                role.PlantButton.gameObject.SetActive(false);
            }


            role.PlantButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);

            var notBombed = PlayerControl.AllPlayerControls.ToArray().Where(
                player => role.BombPlayer?.PlayerId != player.PlayerId
            ).ToList();

            if (!role.BombAttached)
            {
                role.PlantButton.graphic.sprite = PlantSprite;
                Utils.SetTarget(ref role.ClosestPlayer, role.PlantButton, GameOptionsData.KillDistances[GameOptionsManager.Instance.currentNormalGameOptions.KillDistance], notBombed);
                role.PlantButton.SetCoolDown(role.PlantTimer(false), CustomGameOptions.DetonatorPlantCooldown);
            }
            else
            {
                role.PlantButton.graphic.sprite = DetonateSprite;
                role.PlantButton.SetTarget(null);
                role.PlantButton.graphic.color = new(255, 255, 255, 1);
                role.PlantButton.SetCoolDown(role.PlantTimer(true), CustomGameOptions.DetonatorDetonateCooldown);
            }
            

            if (role.BombPlayer != null && !role.BombPlayer.Data.IsDead && !role.BombPlayer.Data.Disconnected)
            {
                role.BombPlayer.myRend().material.SetFloat("_Outline", 1f);
                role.BombPlayer.myRend().material.SetColor("_OutlineColor", new Color(0.3f, 0.0f, 0.0f));
                if (role.BombPlayer.GetCustomOutfitType() != CustomPlayerOutfitType.Camouflage &&
                    role.BombPlayer.GetCustomOutfitType() != CustomPlayerOutfitType.Swooper)
                    role.BombPlayer.nameText().color = new Color(0.3f, 0.0f, 0.0f);
                else role.BombPlayer.nameText().color = Color.clear;
            }

            var imps = PlayerControl.AllPlayerControls.ToArray().Where(
                player => player.Data.IsImpostor() && player != role.BombPlayer
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
