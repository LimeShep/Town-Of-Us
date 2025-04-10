using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.ImpostorRoles.DetonatorMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingStart
    {
        public static void Postfix(MeetingHud __instance)
        {
            var role = Role.GetRole<Detonator>(PlayerControl.LocalPlayer);
            if(role != null) role.CancelDetonation();
        }
    }
}