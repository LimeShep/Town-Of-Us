using System;
using System.Timers;
using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Disorienter : Role
    {
        public KillButton _disorientButton;

        public PlayerControl ClosestPlayer;
        public PlayerControl Disoriented;
        public DateTime LastDisoriented { get; set; }

        Timer _timer;

        public Disorienter(PlayerControl player) : base(player)
        {
            Name = "Disorienter";
            ImpostorText = () => "Disorient Crewmates by flipping their screen";
            TaskText = () => "Flip a crewmate screen";
            Color = Patches.Colors.Impostor;
            LastDisoriented = DateTime.UtcNow;
            RoleType = RoleEnum.Disorienter;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }

        public KillButton DisorientButton
        {
            get => _disorientButton;
            set
            {
                _disorientButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public float DisorientTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastDisoriented;
            var num = CustomGameOptions.DisorientCd * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public void Disorient(PlayerControl player)
        {
            Disoriented = player;

            if (player == PlayerControl.LocalPlayer)
            {
                Camera.main.transform.rotation = Quaternion.Euler(0, 0, 180);
                foreach (var p in PlayerControl.AllPlayerControls) p.nameText().gameObject.SetActive(false);

                _timer = new();
                _timer.Elapsed += FinishDisorient;
                _timer.Interval = CustomGameOptions.DisorientTime * 1000;
                _timer.Start();
            }
        }

        public void FinishDisorient(object sender = null, ElapsedEventArgs e = null)
        {
            Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
            foreach (var p in PlayerControl.AllPlayerControls) p.nameText().gameObject.SetActive(true);
            _timer.Stop();
        }
    }
}