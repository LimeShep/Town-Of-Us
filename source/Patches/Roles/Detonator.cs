using UnityEngine;
using System;
using TownOfUs.CrewmateRoles.MedicMod;
using TownOfUs.Patches;
using System.Collections;
using Reactor.Utilities;

namespace TownOfUs.Roles
{
    public class Detonator : Role

    {
        public KillButton _plantButton;
        public KillButton _detonateButton;
        public bool Detonated = false;
        public bool BombAttached = false;
        public PlayerControl ClosestPlayer;
        public AudioSource BeepSource;
        public PlayerControl BombPlayer;
        public DateTime LastPlanted;
        public DateTime StartingCooldown { get; set; }

        public Detonator(PlayerControl player) : base(player)
        {
            Name = "Detonator";
            ImpostorText = () => "Attach Bombs To Kill Multiple Crewmates At Once";
            TaskText = () => "Detonate crewmates";
            Color = Palette.ImpostorRed;
            LastPlanted = DateTime.UtcNow;
            StartingCooldown = DateTime.UtcNow;
            RoleType = RoleEnum.Detonator;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }
        public KillButton PlantButton
        {
            get => _plantButton;
            set
            {
                _plantButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public KillButton DetonateButton
        {
            get => _detonateButton;
            set
            {
                _detonateButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
        public float PlantTimer(bool detonate)
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastPlanted;
            var num = !detonate ? CustomGameOptions.DetonatorPlantCooldown * 1000f
                : CustomGameOptions.DetonatorDetonateCooldown * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public void Plant(PlayerControl player)
        {
            Utils.Rpc(CustomRPC.DetonatorBombBeep, PlayerControl.LocalPlayer.PlayerId, player.PlayerId);
            RpcPlant(player);
        }
        public void RpcPlant(PlayerControl player)
        {
            if (BeepSource != null) return;

            GameObject obj = new("SFx_BombTicking");
            obj.transform.position = player.transform.position;
            BeepSource = obj.AddComponent<AudioSource>();


            BeepSource.loop = true;
            BeepSource.volume = 0.2f;
            if(player != PlayerControl.LocalPlayer) BeepSource.spatialBlend = 1.0f;
            BeepSource.minDistance = 1f;
            BeepSource.maxDistance = 2f;
            BeepSource.rolloffMode = AudioRolloffMode.Linear;

            BeepSource.Play();

            Coroutines.Start(SoundFollowPlayer());
        }

        public void Detonate(PlayerControl playerToDetonate)
        {
            var playersToDie = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            
            if (CustomGameOptions.DetonatorMaxKillsInDetonation == 1) playersToDie.Add(playerToDetonate);
            else playersToDie = Utils.GetClosestPlayers(playerToDetonate.transform.position, CustomGameOptions.DetonatorRadius, false);

            playersToDie = Shuffle(playersToDie);
            
            while (playersToDie.Count > CustomGameOptions.DetonatorMaxKillsInDetonation) playersToDie.Remove(playersToDie[playersToDie.Count - 1]);
            foreach (var player in playersToDie)
            {
                if (!player.Is(RoleEnum.Pestilence) && !player.IsShielded() && !player.IsProtected() && player != ShowRoundOneShield.FirstRoundShielded)
                {
                    Utils.RpcMultiMurderPlayer(Player, player);
                }
                else if (player.IsShielded())
                {
                    var medic = player.GetMedic().Player.PlayerId;
                    Utils.Rpc(CustomRPC.AttemptSound, medic, player.PlayerId);
                    StopKill.BreakShield(medic, player.PlayerId, CustomGameOptions.ShieldBreaks);
                }
            }
        }
        public static Il2CppSystem.Collections.Generic.List<PlayerControl> Shuffle(Il2CppSystem.Collections.Generic.List<PlayerControl> playersToDie)
        {
            var count = playersToDie.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = UnityEngine.Random.Range(i, count);
                var tmp = playersToDie[i];
                playersToDie[i] = playersToDie[r];
                playersToDie[r] = tmp;
            }
            return playersToDie;
        }
        public void CancelDetonation()
        {
            BombAttached = false;
            BombPlayer = null;
        }

        IEnumerator SoundFollowPlayer()
        {
            yield return new WaitForSeconds(0.1f);
            if (BeepSource != null && BombPlayer != null && !BombPlayer.Data.IsDead && !MeetingHud.Instance)
            {
                BeepSource.transform.position = BombPlayer.transform.position;
                Coroutines.Start(SoundFollowPlayer());
            }
            else
            {
                GameObject.Destroy(BeepSource.gameObject);
                BeepSource = null;
            }
        }
    }
}