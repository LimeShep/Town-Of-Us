using HarmonyLib;
using Object = UnityEngine.Object;
using Reactor.Utilities.Extensions;
using UnityEngine;
using TownOfUs.Patches;
using TownOfUs.Roles;
using TownOfUs.NeutralRoles.ShifterMod;
using Hazel;

namespace TownOfUs
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingHud_Start
    {
        public static void Postfix(MeetingHud __instance)
        {
            Utils.ShowDeadBodies = PlayerControl.LocalPlayer.Data.IsDead;

            foreach (var player in PlayerControl.AllPlayerControls)
            {
                player.MyPhysics.ResetAnimState();
            }

            HudUpdate.Zooming = false;
            Camera.main.orthographicSize = 3f;

            foreach (var cam in Camera.allCameras)
            {
                if (cam?.gameObject.name == "UI Camera")
                    cam.orthographicSize = 3f;
            }

            foreach (var player in PlayerControl.AllPlayerControls) {
                if (player.Is(RoleEnum.Shifter)) {
                    var role = Role.GetRole<Shifter>(player);
                    if (role.Used && CustomGameOptions.ShiftHappensOnMeeting && role.otherPlayer != null) {
                        var shiftedPlayer = role.otherPlayer;
                        role.otherPlayer = null;
                        
                        var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                            (byte) CustomRPC.Shift, SendOption.Reliable, -1);
                        writer.Write(PlayerControl.LocalPlayer.PlayerId);
                        writer.Write(shiftedPlayer.PlayerId);
                        AmongUsClient.Instance.FinishRpcImmediately(writer);

                        PerformKillButton.Shift(role, shiftedPlayer);
                    }
                }
            }

            ResolutionManager.ResolutionChanged.Invoke((float)Screen.width / Screen.height, Screen.width, Screen.height, Screen.fullScreen);
        }
    }

    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Close))]
    public class MeetingHud_Close
    {
        public static void Postfix(MeetingHud __instance)
        {
            Utils.Rpc(CustomRPC.RemoveAllBodies);
            var buggedBodies = Object.FindObjectsOfType<DeadBody>();
            foreach (var body in buggedBodies)
            {
                body.gameObject.Destroy();
            }
        }
    }

    [HarmonyPatch(typeof(ExileController), nameof(ExileController.BeginForGameplay))]
    public class ExileAnimStart
    {
        public static void Postfix(ExileController __instance, [HarmonyArgument(0)] NetworkedPlayerInfo exiled, [HarmonyArgument(1)] bool tie)
        {
            Utils.ShowDeadBodies = PlayerControl.LocalPlayer.Data.IsDead || exiled?.PlayerId == PlayerControl.LocalPlayer.PlayerId;
        }
    }
}