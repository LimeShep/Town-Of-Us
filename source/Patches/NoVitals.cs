using HarmonyLib;
using UnityEngine;

namespace TownOfUs.Patches
{
    [HarmonyPatch(typeof(VitalsMinigame), nameof(VitalsMinigame.Begin))]
    public class NoVitals
    {
        public static bool Prefix(VitalsMinigame __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return true;
            if ((PlayerControl.LocalPlayer.Is(RoleEnum.Transporter) && !CustomGameOptions.TransporterVitals) ||
                (PlayerControl.LocalPlayer.Is(RoleEnum.TimeLord) && !CustomGameOptions.TimeLordVitals))
            {
                Object.Destroy(__instance.gameObject);
                return false;
            }

            return true;
        }
    }
}