using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using TownOfUs.Roles.Modifiers;
using TownOfUs.NeutralRoles.SpeedrunnerMod;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace TownOfUs
{
    internal static class TaskPatches
    {
        [HarmonyPatch(typeof(GameData), nameof(GameData.RecomputeTaskCounts))]
        private class GameData_RecomputeTaskCounts
        {
            private static bool Prefix(GameData __instance)
            {
                __instance.TotalTasks = 0;
                __instance.CompletedTasks = 0;
                for (var i = 0; i < __instance.AllPlayers.Count; i++)
                {
                    var playerInfo = __instance.AllPlayers.ToArray()[i];
                    if (!playerInfo.Disconnected && playerInfo.Tasks != null && playerInfo.Object &&
                        (GameOptionsManager.Instance.currentNormalGameOptions.GhostsDoTasks || !playerInfo.IsDead) && !playerInfo.IsImpostor() &&
                        !(
                            playerInfo._object.Is(RoleEnum.Jester) || playerInfo._object.Is(RoleEnum.Amnesiac) || playerInfo._object.Is(RoleEnum.Shifter) ||
                            playerInfo._object.Is(RoleEnum.Survivor) || playerInfo._object.Is(RoleEnum.GuardianAngel) ||
                            playerInfo._object.Is(RoleEnum.Glitch) || playerInfo._object.Is(RoleEnum.Executioner) ||
                            playerInfo._object.Is(RoleEnum.Arsonist) || playerInfo._object.Is(RoleEnum.Juggernaut) ||
                            playerInfo._object.Is(RoleEnum.Plaguebearer) || playerInfo._object.Is(RoleEnum.Pestilence) ||
                            playerInfo._object.Is(RoleEnum.Werewolf) || playerInfo._object.Is(RoleEnum.Doomsayer) || playerInfo._object.Is(RoleEnum.Foreteller) ||
                            playerInfo._object.Is(RoleEnum.Vampire) || playerInfo._object.Is(RoleEnum.SoulCollector) || playerInfo._object.Is(RoleEnum.Speedrunner) ||
                            playerInfo._object.Is(RoleEnum.Phantom) || playerInfo._object.Is(RoleEnum.Haunter) ||
                            (playerInfo._object.Is(ModifierEnum.Lover) && !Modifier.GetModifier<Lover>(playerInfo._object).OtherLover.Player.Is(Faction.Crewmates))
                        ))
                    {
                        for (var j = 0; j < playerInfo.Tasks.Count; j++)
                        {
                            __instance.TotalTasks++;
                            if (playerInfo.Tasks.ToArray()[j].Complete) __instance.CompletedTasks++;
                        }
                    }
                    /*else if (!playerInfo.Disconnected && playerInfo.Tasks != null && playerInfo.Object && playerInfo.Object.Is(RoleEnum.Speedrunner) && !playerInfo.IsDead) {
                        //playerInfo.RpcSetTasks(byte[], )
                        Speedrunner role = (Speedrunner)Role.GetRole(playerInfo.Object);
                        if (!role.AddedTasks) {
                            role.AddedTasks = true;
                            int index1 = Utils.GetRandomShortTask();
                            int index2 = Utils.GetRandomLongTask();

                            Utils.SetTask(playerInfo, index1);
                            Utils.SetTask(playerInfo, index2);
                            role.RegenTask();
                        }
                    }*/
                    else if (!playerInfo.Disconnected && playerInfo.Tasks != null && playerInfo.Object && playerInfo.Object.Is(RoleEnum.Speedrunner) && !playerInfo.IsDead) {
                        Speedrunner role = (Speedrunner)Role.GetRole(playerInfo.Object);
                        if (!role.AddedTasks) {
                            role.AddedTasks = true;

                            // Używamy System.Collections.Generic.List<byte> zamiast byte[], aby dynamicznie dodawać elementy
                            System.Collections.Generic.List<byte> taskIds = new System.Collections.Generic.List<byte>(); 
                            int index;

                            // Dodawanie Common Tasks
                            for (int j = 0; j < (int)CustomGameOptions.SpeedrunnerCommonTask; j++) {
                                index = Utils.GetRandomCommonTaskId();
                                taskIds.Add((byte)index); // Dodajemy wartość do listy
                            }

                            // Dodawanie Short Tasks
                            for (int j = 0; j < (int)CustomGameOptions.SpeedrunnerShortTask; j++) {
                                index = Utils.GetRandomShortTask();
                                taskIds.Add((byte)index);
                            }

                            // Dodawanie Long Tasks
                            for (int j = 0; j < (int)CustomGameOptions.SpeedrunnerLongTask; j++) {
                                index = Utils.GetRandomLongTask();
                                taskIds.Add((byte)index);
                            }

                            // Tworzymy Il2CppStructArray<byte> o odpowiednim rozmiarze
                            Il2CppStructArray<byte> il2cppTaskIds = new Il2CppStructArray<byte>(taskIds.Count);

                            // Ręczne kopiowanie danych z listy do Il2CppStructArray
                            for (int k = 0; k < taskIds.Count; k++) {
                                il2cppTaskIds[k] = taskIds[k];
                            }

                            playerInfo.RpcSetTasks(il2cppTaskIds);
                        }

                    }
                    if (CustomGameOptions.SyzyfowyAmong) {
                        for (var j = 0; j < playerInfo.Tasks.Count; j++)
                        {
                            __instance.TotalTasks++;
                            if (playerInfo.Tasks.ToArray()[j].Complete) __instance.CompletedTasks++;
                        }
                    }
                }

                return false;
            }
        }

        [HarmonyPatch(typeof(Console), nameof(Console.CanUse))]
        private class Console_CanUse
        {
            private static bool Prefix(Console __instance, [HarmonyArgument(0)] NetworkedPlayerInfo playerInfo, ref float __result, ref bool canUse, ref bool couldUse)
            {
                var playerControl = playerInfo.Object;

                var flag = playerControl.Is(RoleEnum.Glitch)
                           || playerControl.Is(RoleEnum.Jester)
                           || playerControl.Is(RoleEnum.Executioner)
                           || playerControl.Is(RoleEnum.Juggernaut)
                           || playerControl.Is(RoleEnum.Arsonist)
                           || playerControl.Is(RoleEnum.Plaguebearer)
                           || playerControl.Is(RoleEnum.Pestilence)
                           || playerControl.Is(RoleEnum.Werewolf)
                           || playerControl.Is(RoleEnum.Doomsayer)
                           || playerControl.Is(RoleEnum.Foreteller)
                           || playerControl.Is(RoleEnum.Vampire)
                           || playerControl.Is(RoleEnum.SoulCollector);

                // If the console is not a sabotage repair console
                if (flag && !__instance.AllowImpostor)
                {
                    __result = float.MaxValue;
                    canUse = false;
                    couldUse = false;
                    return false;
                }

                if (CamouflageUnCamouflage.TasksDisabled && (playerControl.Is(Faction.Crewmates) || playerControl.Is(Faction.NeutralBenign) || playerControl.Is(RoleEnum.Speedrunner) || playerControl.Is(RoleEnum.Phantom)) && !__instance.AllowImpostor) {
                    __result = float.MaxValue;
                    canUse = false;
                    couldUse = false;
                    return false;
                }
                
                return true;
            }
        }

        [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CompleteTask))]
        public class CompleteTask
        {
            public static void Postfix(PlayerControl __instance)
            {
                if (__instance.Is(RoleEnum.Haunter) || !__instance.Is(Faction.Crewmates)) GameData.Instance.CompletedTasks--;
            }
        }
    }
}