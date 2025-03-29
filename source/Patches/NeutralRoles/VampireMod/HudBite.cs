using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;

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

            if (!role.madeASideKick || !role.isSidekick) biteButton.graphic.sprite = TownOfUs.Sidekick;
            else biteButton.graphic.sprite = __instance.KillButton.graphic.sprite;

            biteButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            biteButton.SetCoolDown(role.BiteTimer(), CustomGameOptions.BiteCd);

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
