using System.Linq;
using HarmonyLib;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.SpeedrunnerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class UpdateArrows
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;

            foreach (var role in Role.AllRoles.Where(x => x.RoleType == RoleEnum.Speedrunner))
            {
                var speed = (Speedrunner)role;
                if (PlayerControl.LocalPlayer.Data.IsDead || speed.Player.Data.IsDead)
                {
                    speed.SpeedArrows.Values.DestroyAll();
                    speed.SpeedArrows.Clear();
                    speed.ImpArrows.DestroyAll();
                    speed.ImpArrows.Clear();
                }

                foreach (var arrow in speed.ImpArrows) arrow.target = speed.Player.transform.position;

                foreach (var arrow in speed.SpeedArrows)
                {
                    var player = Utils.PlayerById(arrow.Key);
                    if (player == null || player.Data == null || player.Data.IsDead || player.Data.Disconnected)
                    {
                        speed.DestroyArrow(arrow.Key);
                        continue;
                    }
                    arrow.Value.target = player.transform.position;
                }
            }
        }
    }
}