using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.EvokerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    [HarmonyPriority(Priority.Last)]
    public class BlindUnBlind
    {
        [HarmonyPriority(Priority.Last)]
        public static void Postfix(HudManager __instance)
        {
            foreach (var role in Role.GetRoles(RoleEnum.Evoker))
            {
                var evoker = (Evoker) role;
                if (evoker.Evoked)
                    evoker.Evoke();
                else if (evoker.Active) evoker.Unevoke();
            }
        }
    }
}