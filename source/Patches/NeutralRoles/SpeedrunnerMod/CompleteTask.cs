using System.Linq;
using HarmonyLib;
using Reactor.Utilities;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SpeedrunnerMod
{
    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CompleteTask))]
    public class CompleteTask
    {
        public static Sprite Sprite => TownOfUs.Arrow;

        public static void Postfix(PlayerControl __instance)
        {
            if (!__instance.Is(RoleEnum.Speedrunner)) return;
            if (__instance.Data.IsDead) return;
            var taskinfos = __instance.Data.Tasks.ToArray();

            var tasksLeft = taskinfos.Count(x => !x.Complete);
            var role = Role.GetRole<Speedrunner>(__instance);
            var localRole = Role.GetRole(PlayerControl.LocalPlayer);
            switch (tasksLeft)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    if (tasksLeft == CustomGameOptions.SpeedrunnerTasksRemaining)
                    {
                        Coroutines.Start(Utils.FlashCoroutine(Color.green));
                        var impostors = PlayerControl.AllPlayerControls.ToArray();
                        foreach (var imp in impostors)
                        {
                            if (imp.Is(RoleEnum.Speedrunner))
                            {
                                var gameObj = new GameObject();
                                var arrow = gameObj.AddComponent<ArrowBehaviour>();
                                gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                                var renderer = gameObj.AddComponent<SpriteRenderer>();
                                renderer.sprite = Sprite;
                                arrow.image = renderer;
                                gameObj.layer = 5;
                                role.SpeedArrows.Add(imp.PlayerId, arrow);
                            }
                        }
                        role.RegenTask();
                        if (!PlayerControl.LocalPlayer.Is(RoleEnum.Speedrunner))
                        {
                            Coroutines.Start(Utils.FlashCoroutine(Color.white));
                        }
                        else if (!PlayerControl.LocalPlayer.Is(RoleEnum.Speedrunner)) {
                            Coroutines.Start(Utils.FlashCoroutine(role.Color));
                            var people = PlayerControl.AllPlayerControls.ToArray().Where(x => Role.GetRole(x).RoleType == RoleEnum.Speedrunner);
                            foreach (var player in people) {
                                var gameObj = new GameObject();
                                var arrow = gameObj.AddComponent<ArrowBehaviour>();
                                gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                                var renderer = gameObj.AddComponent<SpriteRenderer>();
                                renderer.sprite = Sprite;
                                arrow.image = renderer;
                                gameObj.layer = 5;
                                role.SpeedArrows.Add(player.PlayerId, arrow);
                            }
                        }
                    }
                    break;

                case 0:
                    role.RegenTask();
                    role.FinishedAllTasks = true;
                    role.Wins();
                    break;
            }
        }
    }
}