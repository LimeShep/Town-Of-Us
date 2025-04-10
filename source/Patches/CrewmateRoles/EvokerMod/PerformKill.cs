using HarmonyLib;
using Hazel;
using TownOfUs.Extensions;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.EvokerMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformKill
    {
        public static bool Prefix(KillButton __instance)
        {
            if (__instance != DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            //System.Console.WriteLine($"IS IMP: ${PlayerControl.LocalPlayer.Is(Faction.Impostors)}\n IS NEU: ${PlayerControl.LocalPlayer.Is(Faction.NeutralKilling)}\nEVOKED:${RpcHandling.evoked}\nCHECK: {(PlayerControl.LocalPlayer.Is(Faction.Impostors) || PlayerControl.LocalPlayer.Is(Faction.NeutralKilling)) && RpcHandling.evoked}");
            //if ((PlayerControl.LocalPlayer.Is(Faction.Impostors) || PlayerControl.LocalPlayer.Is(Faction.NeutralKilling)) && RpcHandling.evoked) return false;

            var flag = PlayerControl.LocalPlayer.Is(RoleEnum.Evoker);
            if (!flag) return true;
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var role = Role.GetRole<Evoker>(PlayerControl.LocalPlayer);
            var target = DestroyableSingleton<HudManager>.Instance.KillButton.currentTarget;

            if (__instance.isCoolingDown) return false;
            if (!__instance.isActiveAndEnabled) return false;
            if (role.BlindTimer() != 0) return false;
            role.TimeRemaining = CustomGameOptions.EvokerDuration;

            Utils.Rpc(CustomRPC.Evoke, PlayerControl.LocalPlayer.PlayerId);
            RpcHandling.evoked = true;
            role.Active = true;
            return true;
        }
    }
}