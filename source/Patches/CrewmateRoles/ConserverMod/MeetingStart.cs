using HarmonyLib;
using TownOfUs.Roles;
using System;
using System.Linq;

namespace TownOfUs.CrewmateRoles.ConserverMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingStart
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Conserver)) return;
            var conserverRole = Role.GetRole<Conserver>(PlayerControl.LocalPlayer);

            conserverRole.UsesLeft++;
            return;    
        }
    }
}
