using System.Collections.Generic;
using TownOfUs.Extensions;
using UnityEngine;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using System;

namespace TownOfUs.Roles
{
    public class Evoker : Role
    {
        public Evoker(PlayerControl player) : base(player)
        {
            Name = "Evoker";
            ImpostorText = () => "Blind impostors";
            TaskText = () => "Make impostors delusional";
            Color = Patches.Colors.Evoker;
            RoleType = RoleEnum.Evoker;
            AddToRoleHistory(RoleType);
            Faction = Faction.Crewmates;
            LastBlinded = DateTime.UtcNow;
            Active = false;
        }

        public DateTime LastBlinded;
        public float TimeRemaining;
        public bool Evoked => TimeRemaining > 0f;
        public bool Active;

        public float BlindTimer(){
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastBlinded;
            var num = CustomGameOptions.EvokerCooldown * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public void Evoke()
        {
            Active = true;
            RpcHandling.evoked = true;
            Utils.Evoke();
            TimeRemaining -= Time.deltaTime;
            if (Player.Data.IsDead)
            {
                TimeRemaining = 0f;
            }
        }

        public void Unevoke()
        {
            LastBlinded = DateTime.UtcNow;
            Active = false;
            RpcHandling.evoked = false;

            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player.GetCustomOutfitType() == CustomPlayerOutfitType.Swooper) player.myRend().color = UnityEngine.Color.white;
                if (player.Is(RoleEnum.Swooper))
                {
                    var swooper = GetRole<Swooper>(player);
                    if (swooper.IsSwooped) continue;
                }
                else if (player.Is(RoleEnum.Venerer))
                {
                    var venerer = GetRole<Venerer>(player);
                    if (venerer.IsCamouflaged) continue;
                }
                else if (player.Is(RoleEnum.Morphling))
                {
                    var morphling = GetRole<Morphling>(player);
                    if (morphling.Morphed) continue;
                }
                else if (player.Is(RoleEnum.Glitch))
                {
                    var glitch = GetRole<Glitch>(player);
                    if (glitch.IsUsingMimic) continue;
                }
                else if (CamouflageUnCamouflage.IsCamoed) continue;
                player.SetOutfit(CustomPlayerOutfitType.Default);
            }
        }
    }
}