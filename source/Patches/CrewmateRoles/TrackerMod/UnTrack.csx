using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.ImpostorRoles.CamouflagerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class UnTrack
    {
        public static void Postfix(HudManager __instance) {
            
            bool TrackingEnabled = false;

            foreach (var role in Role.GetRoles(RoleEnum.Tracker))
            {
                var tracker = (Tracker) role;
                if (tracker.Tracked)
                {
                    TrackingEnabled = true;
                    tracker.KeepTracking();
                }
                else if (tracker.isTrackingPlayer)
                {
                    TrackingEnabled = false;
                    tracker.StopTrackingPlayer();
                }
            }
        }
    }
}