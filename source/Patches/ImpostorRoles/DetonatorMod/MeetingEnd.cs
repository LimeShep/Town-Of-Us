using HarmonyLib;
using System;
using TownOfUs.Roles;

namespace TownOfUs.Patches.ImpostorRoles.DetonatorMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Close))]
    public class MeetingEnd
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Detonator)) return;
            var role = Role.GetRole<Detonator>(PlayerControl.LocalPlayer);

            role.CancelDetonation();
            role.LastPlanted = DateTime.UtcNow;
        }
    }
}
