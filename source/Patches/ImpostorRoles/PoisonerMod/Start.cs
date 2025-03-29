using System;
using HarmonyLib;
using TownOfUs.Roles;
using TownOfUs.Modifiers.UnderdogMod;

namespace TownOfUs.ImpostorRoles.PoisonerMod
{
    [HarmonyPatch(typeof(IntroCutscene._CoBegin_d__35), nameof(IntroCutscene._CoBegin_d__35.MoveNext))]
    public static class Start
    {
        public static void Postfix(IntroCutscene._CoBegin_d__35 __instance)
        {
            foreach (var role in Role.GetRoles(RoleEnum.Poisoner))
            {
                var poisoner = (Poisoner)role;
                poisoner.LastPoisoned = DateTime.UtcNow;
                if (poisoner.Player.Is(ModifierEnum.Underdog))
                {
                    poisoner.LastPoisoned = poisoner.LastPoisoned.AddSeconds(PerformKill.LastImp() ? CustomGameOptions.UnderdogKillBonus : (PerformKill.IncreasedKC() ? 0f : (-CustomGameOptions.UnderdogKillBonus)));
                }
                poisoner.LastPoisoned = poisoner.LastPoisoned.AddSeconds(CustomGameOptions.InitialCooldowns - CustomGameOptions.PoisonCd);
            }
        }
    }
}