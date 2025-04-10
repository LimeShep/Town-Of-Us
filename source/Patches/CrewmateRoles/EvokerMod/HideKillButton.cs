//if ((PlayerControl.LocalPlayer.Is(Faction.Impostors) || PlayerControl.LocalPlayer.Is(Faction.NeutralKilling)) && RpcHandling.evoked)
using System.Linq;
using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using TownOfUs.Roles.Modifiers;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.EvokerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public static class HideKillButton
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!(PlayerControl.LocalPlayer.Is(Faction.Impostors) || PlayerControl.LocalPlayer.Is(Faction.NeutralKilling))) return;
            var isDead = PlayerControl.LocalPlayer.Data.IsDead;
            var killButton = __instance.KillButton;

            if (!isDead && RpcHandling.evoked) killButton.Hide();
            return;
        }
    }
}