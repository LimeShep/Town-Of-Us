using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.TrackerMod
{
    [HarmonyPatch(typeof(HudManager))]
    public class HudUpdate
    {
        [HarmonyPatch(nameof(HudManager.Update))]
        public static void Postfix(HudManager __instance)
        {
            UpdateInvButton(__instance);
        }

        public static void UpdateInvButton(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Tracker)) return;
            var trackerButton = __instance.KillButton;

            var role = Role.GetRole<Tracker>(PlayerControl.LocalPlayer);

            trackerButton.gameObject.SetActive((__instance.UseButton.isActiveAndEnabled || __instance.PetButton.isActiveAndEnabled)
                    && !MeetingHud.Instance && !PlayerControl.LocalPlayer.Data.IsDead
                    && AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Started);
            trackerButton.SetCoolDown(role.TrackerTimer(), CustomGameOptions.SeerCd);


            Utils.SetTarget(ref role.ClosestPlayer, trackerButton, float.NaN);
        }
    }
}
