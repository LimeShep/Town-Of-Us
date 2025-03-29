using System;
using UnityEngine;
using TownOfUs.Modifiers.UnderdogMod;

namespace TownOfUs.Roles
{
    public class Poisoner : Role

    {
        public KillButton _poisonButton;
        public PlayerControl ClosestPlayer;
        public DateTime LastPoisoned;
        public PlayerControl PoisonedPlayer;
        public float TimeRemaining;
        public bool Enabled = false;

        public Poisoner(PlayerControl player) : base(player)
        {
            Name = "Poisoner";
            ImpostorText = () => "Poison A Crewmate To Kill Them In A Few Seconds";
            TaskText = () => "Poison the crewmates";
            Color = Palette.ImpostorRed;
            LastPoisoned = DateTime.UtcNow;
            RoleType = RoleEnum.Poisoner;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
            PoisonedPlayer = null;
        }
        public KillButton PoisonButton
        {
            get => _poisonButton;
            set
            {
                _poisonButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public bool Poisoned => TimeRemaining > 0f;
        public void Poison()
        {
            Enabled = true;
            TimeRemaining -= Time.deltaTime;
            if (MeetingHud.Instance)
            {
                TimeRemaining = 0;
            }
            if (TimeRemaining <= 0)
            {
                PoisonKill();
            }
        }
        public void PoisonKill()
        {
            if (!PoisonedPlayer.Is(RoleEnum.Pestilence))
            {
                Utils.RpcMurderPlayer(PoisonedPlayer, PoisonedPlayer);
                if (!PoisonedPlayer.Data.IsDead) SoundManager.Instance.PlaySound(PlayerControl.LocalPlayer.KillSfx, false, 0.5f);
            }
            PoisonedPlayer = null;
            Enabled = false;
            LastPoisoned = DateTime.UtcNow;
        }
        public float PoisonTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastPoisoned;
            var num = CustomGameOptions.PoisonCd * 1000f;
            if (Player.Is(ModifierEnum.Underdog))
            {
                num = PerformKill.LastImp() ? (CustomGameOptions.PoisonCd - CustomGameOptions.UnderdogKillBonus) * 1000f :
                    (PerformKill.IncreasedKC() ? CustomGameOptions.PoisonCd * 1000 : (CustomGameOptions.PoisonCd + CustomGameOptions.UnderdogKillBonus) * 1000);
            }
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}