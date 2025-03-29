using System.Collections.Generic;
using TownOfUs.Extensions;
using UnityEngine;
using System.Linq;
using Il2CppSystem.Collections.Generic;

namespace TownOfUs.Roles
{
    public class Speedrunner : Role
    {
        public System.Collections.Generic.List<ArrowBehaviour> ImpArrows = new System.Collections.Generic.List<ArrowBehaviour>();

        public System.Collections.Generic.Dictionary<byte, ArrowBehaviour> SpeedArrows = new System.Collections.Generic.Dictionary<byte, ArrowBehaviour>();
        public Speedrunner(PlayerControl player) : base(player)
        {
            Name = "Speedrunner";
            ImpostorText = () => "Complete tasks as fast as possible";
            TaskText = () => "Complete all tasks to win instantly!";
            Color = Patches.Colors.Speedrunner;
            RoleType = RoleEnum.Speedrunner;
            AddToRoleHistory(RoleType);
            Faction = Faction.NeutralEvil;

            //Utils.Rpc(CustomRPC.AddSpeedrunnerTasks);
        }

        public bool Revealed => TasksLeft <= CustomGameOptions.SpeedrunnerTasksRemaining;
        public bool FinishedAllTasks = false;
        public bool AddedTasks = false;

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__38 __instance)
        {
            var speedTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            speedTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = speedTeam;
        }
        internal override bool Criteria()
        {
            return Revealed && PlayerControl.LocalPlayer.Data.IsImpostor() && !Player.Data.IsDead ||
                   base.Criteria();
        }

        internal override bool RoleCriteria()
        {
            var localPlayer = PlayerControl.LocalPlayer;
            if (localPlayer.Data.IsImpostor() && !Player.Data.IsDead)
            {
                return Revealed || base.RoleCriteria();
            }
            else if (GetRole(localPlayer).Faction == Faction.NeutralKilling && !Player.Data.IsDead)
            {
                return Revealed && CustomGameOptions.SnitchSeesNeutrals || base.RoleCriteria();
            }
            return false || base.RoleCriteria();
        }

        public void DestroyArrow(byte targetPlayerId)
        {
            var arrow = SpeedArrows.FirstOrDefault(x => x.Key == targetPlayerId);
            if (arrow.Value != null)
                Object.Destroy(arrow.Value);
            if (arrow.Value.gameObject != null)
                Object.Destroy(arrow.Value.gameObject);
            SpeedArrows.Remove(arrow.Key);
        }

        internal override bool GameEnd(LogicGameFlowNormal __instance)
        {
            if (!FinishedAllTasks || Player.Data.Disconnected) return true;
            if (!CustomGameOptions.NeutralEvilWinEndsGame) return true;
            Utils.EndGame();
            return false;
        }

        public void Wins()
        {
            FinishedAllTasks = true;
        }
    }
}