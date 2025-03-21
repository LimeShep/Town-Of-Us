using HarmonyLib;
using AmongUs;

namespace TownOfUs {
     [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingShowerPatch
    {
        public static void Postfix(PingTracker __instance)
        {
            __instance.text.text += "<line-height=50%><indent=25%>\n<size=70%><align=center><color=#D6B878FF>Syzyfowy Town of Us</color><color=#00FF00FF> 6.2.5</color></align></indent>";
        }
    }
    /*[HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingShowerPatch
    {
        public static void Postfix(PingTracker __instance)
        {
            __instance.text.text = "<size=60%><color=#D6B878FF>Syzyfowy Town of Us</color> <color=#00FF00FF>" + TownOfUs.VersionString + "</color>" + TownOfUs.VersionTag;
        }
    }*/
}