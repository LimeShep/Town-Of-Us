using HarmonyLib;

namespace TownOfUs
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class CamouflageUnCamouflage
    {
        public static bool CommsEnabled;

        public static bool IsCamoed => CommsEnabled;

        public static bool ShouldTasksBeDisabled;
        public static bool TasksDisabled => ShouldTasksBeDisabled;

        public static void Postfix(HudManager __instance)
        {
            if (CustomGameOptions.ColourblindComms)
            {
                if (ShipStatus.Instance != null)
                    switch (GameOptionsManager.Instance.currentNormalGameOptions.MapId)
                    {
                        default:
                        case 0:
                        case 2:
                        case 3:
                        case 4:
                        case 6:
                            var comms1 = ShipStatus.Instance.Systems[SystemTypes.Comms].Cast<HudOverrideSystemType>();
                            if (comms1.IsActive)
                            {
                                CommsEnabled = true;
                                Utils.GroupCamouflage();
                                return;
                            }

                            break;
                        case 1:
                        case 5:
                            var comms2 = ShipStatus.Instance.Systems[SystemTypes.Comms].Cast<HqHudSystemType>();
                            if (comms2.IsActive)
                            {
                                CommsEnabled = true;
                                Utils.GroupCamouflage();
                                return;
                            }

                            break;
                    }

                if (CommsEnabled)
                {
                    CommsEnabled = false;
                    Utils.UnCamouflage();
                }
            }
            if (CustomGameOptions.CommsDisableTasks)
            {
                if (ShipStatus.Instance != null)
                    switch (GameOptionsManager.Instance.currentNormalGameOptions.MapId)
                    {
                        default:
                        case 0:
                        case 2:
                        case 3:
                        case 4:
                        case 6:
                            var comms1 = ShipStatus.Instance.Systems[SystemTypes.Comms].Cast<HudOverrideSystemType>();
                            if (comms1.IsActive)
                            {
                                ShouldTasksBeDisabled = true;
                                return;
                            }

                            break;
                        case 1:
                        case 5:
                            var comms2 = ShipStatus.Instance.Systems[SystemTypes.Comms].Cast<HqHudSystemType>();
                            if (comms2.IsActive)
                            {
                                ShouldTasksBeDisabled = true;
                                return;
                            }

                            break;
                    }

                if (ShouldTasksBeDisabled)
                {
                    ShouldTasksBeDisabled = false;
                }
            }
        }
    }
}