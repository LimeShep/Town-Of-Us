﻿using HarmonyLib;
using TownOfUs.CrewmateRoles.ImitatorMod;
using TownOfUs.Extensions;
using TownOfUs.Roles;

namespace TownOfUs.NeutralRoles.ForetellerMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
    public class MeetingStart
    {
        public static void Postfix(MeetingHud __instance)
        {
            if (PlayerControl.LocalPlayer.Data.IsDead) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Foreteller)) return;
            var foretellerRole = Role.GetRole<Foreteller>(PlayerControl.LocalPlayer);
            if (foretellerRole.LastObservedPlayer != null && !CustomGameOptions.ForetellerCantObserve)
            {
                var playerResults = PlayerReportFeedback(foretellerRole.LastObservedPlayer);
                var roleResults = RoleReportFeedback(foretellerRole.LastObservedPlayer);

                if (!string.IsNullOrWhiteSpace(playerResults)) DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, playerResults);
                if (!string.IsNullOrWhiteSpace(roleResults)) DestroyableSingleton<HudManager>.Instance.Chat.AddChat(PlayerControl.LocalPlayer, roleResults);
            }
        }

        public static string PlayerReportFeedback(PlayerControl player)
        {
            if (player.Is(RoleEnum.Aurial) || player.Is(RoleEnum.Imitator) || StartImitate.ImitatingPlayer == player
                || player.Is(RoleEnum.Morphling) || player.Is(RoleEnum.Mystic)
                 || player.Is(RoleEnum.Spy) || player.Is(RoleEnum.Glitch) || player.Is(RoleEnum.Evoker))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} has an altered perception of reality";
            else if (player.Is(RoleEnum.Blackmailer) || player.Is(RoleEnum.Detective) || player.Is(RoleEnum.Doomsayer) || player.Is(RoleEnum.Foreteller)
                 || player.Is(RoleEnum.Oracle) || player.Is(RoleEnum.Snitch) || player.Is(RoleEnum.Trapper) || player.Is(RoleEnum.Speedrunner) || player.Is(RoleEnum.Disorienter) || player.Is(RoleEnum.Security))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} has an insight for private information";
            else if (player.Is(RoleEnum.Altruist) || player.Is(RoleEnum.Amnesiac) || player.Is(RoleEnum.Janitor)
                 || player.Is(RoleEnum.Medium) || player.Is(RoleEnum.SoulCollector) || player.Is(RoleEnum.Undertaker) || player.Is(RoleEnum.Vampire) || player.Is(RoleEnum.TimeLord))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} has an unusual obsession with dead bodies";
            else if (player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Investigator) || player.Is(RoleEnum.Lookout) || player.Is(RoleEnum.Scavenger)
                 || player.Is(RoleEnum.Swooper) || player.Is(RoleEnum.Tracker) || player.Is(RoleEnum.Werewolf) || player.Is(RoleEnum.Poisoner))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} is well trained in hunting down prey";
            else if (player.Is(RoleEnum.Arsonist) || player.Is(RoleEnum.Hypnotist) || player.Is(RoleEnum.Miner) || player.Is(RoleEnum.Pestilence)
                 || player.Is(RoleEnum.Plaguebearer) || player.Is(RoleEnum.Prosecutor) || player.Is(RoleEnum.Seer) || player.Is(RoleEnum.Transporter))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} spreads fear amonst the group";
            else if (player.Is(RoleEnum.Engineer) || player.Is(RoleEnum.Conserver) || player.Is(RoleEnum.Escapist) || player.Is(RoleEnum.Grenadier) || player.Is(RoleEnum.GuardianAngel)
                 || player.Is(RoleEnum.Medic) || player.Is(RoleEnum.Survivor) || player.Is(RoleEnum.Warden))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} hides to guard themself or others";
            else if (player.Is(RoleEnum.Executioner) || player.Is(RoleEnum.Jester) || player.Is(RoleEnum.President) || player.Is(RoleEnum.Politician)
                 || player.Is(RoleEnum.Swapper) || player.Is(RoleEnum.Traitor) || player.Is(RoleEnum.Venerer) || player.Is(RoleEnum.Veteran) || player.Is(RoleEnum.Camouflager) || player.Is(RoleEnum.Shifter))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} has a trick up their sleeve";
            else if (player.Is(RoleEnum.Bomber) || player.Is(RoleEnum.Deputy) || player.Is(RoleEnum.Jailor) || player.Is(RoleEnum.Juggernaut)
                 || player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Vigilante) || player.Is(RoleEnum.Warlock) || player.Is(RoleEnum.Detonator))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} is capable of performing relentless attacks";
            else if (player.Is(RoleEnum.Crewmate) || player.Is(RoleEnum.Impostor))
                return $"You observe that {player.GetDefaultOutfit().PlayerName} appears to be roleless";
            else
                return "Error";
        }

        public static string RoleReportFeedback(PlayerControl player)
        {
            if (player.Is(RoleEnum.Aurial) || player.Is(RoleEnum.Imitator) || StartImitate.ImitatingPlayer == player
                || player.Is(RoleEnum.Morphling) || player.Is(RoleEnum.Mystic)
                 || player.Is(RoleEnum.Spy) || player.Is(RoleEnum.Glitch) || player.Is(RoleEnum.Evoker))
                return "(Aurial, Imitator, Morphling, Mystic, Spy, The Glitch or Evoker)";
            else if (player.Is(RoleEnum.Blackmailer) || player.Is(RoleEnum.Detective) || player.Is(RoleEnum.Doomsayer) || player.Is(RoleEnum.Foreteller)
                 || player.Is(RoleEnum.Oracle) || player.Is(RoleEnum.Snitch) || player.Is(RoleEnum.Trapper) || player.Is(RoleEnum.Speedrunner) || player.Is(RoleEnum.Disorienter) || player.Is(RoleEnum.Security))
                return "(Blackmailer, Detective, Doomsayer, Foreteller, Oracle, Snitch, Trapper, Speedrunner, Disorienter or Security)";
            else if (player.Is(RoleEnum.Altruist) || player.Is(RoleEnum.Amnesiac) || player.Is(RoleEnum.Janitor)
                 || player.Is(RoleEnum.Medium) || player.Is(RoleEnum.SoulCollector) || player.Is(RoleEnum.Undertaker) || player.Is(RoleEnum.Vampire) || player.Is(RoleEnum.TimeLord))
                return "(Altruist, Amnesiac, Janitor, Medium, Soul Collector, Undertaker, Vampire or Time Lord)";
            else if (player.Is(RoleEnum.Hunter) || player.Is(RoleEnum.Investigator) || player.Is(RoleEnum.Lookout) || player.Is(RoleEnum.Scavenger)
                 || player.Is(RoleEnum.Swooper) || player.Is(RoleEnum.Tracker) || player.Is(RoleEnum.Werewolf) || player.Is(RoleEnum.Poisoner))
                return "(Hunter, Investigator, Lookout, Scavenger, Swooper, Tracker, Werewolf or Poisoner)";
            else if (player.Is(RoleEnum.Arsonist) || player.Is(RoleEnum.Hypnotist) || player.Is(RoleEnum.Miner) || player.Is(RoleEnum.Pestilence)
                 || player.Is(RoleEnum.Plaguebearer) || player.Is(RoleEnum.Prosecutor) || player.Is(RoleEnum.Seer) || player.Is(RoleEnum.Transporter))
                return "(Arsonist, Hypnotist, Miner, Plaguebearer (Pestilence), Prosecutor, Seer or Transporter)";
            else if (player.Is(RoleEnum.Engineer) || player.Is(RoleEnum.Conserver) || player.Is(RoleEnum.Escapist) || player.Is(RoleEnum.Grenadier) || player.Is(RoleEnum.GuardianAngel)
                 || player.Is(RoleEnum.Medic) || player.Is(RoleEnum.Survivor) || player.Is(RoleEnum.Warden))
                return "(Conserver, Engineer, Escapist, Grenadier, Guardian Angel, Medic, Survivor or Warden)";
            else if (player.Is(RoleEnum.Executioner) || player.Is(RoleEnum.Jester) || player.Is(RoleEnum.President) || player.Is(RoleEnum.Politician)
                 || player.Is(RoleEnum.Swapper) || player.Is(RoleEnum.Traitor) || player.Is(RoleEnum.Venerer) || player.Is(RoleEnum.Veteran) || player.Is(RoleEnum.Camouflager) || player.Is(RoleEnum.Shifter))
                return "(Executioner, Jester, Politician, Swapper, Traitor, Venerer, Veteran, Camouflager or Shifter)";
            else if (player.Is(RoleEnum.Bomber) || player.Is(RoleEnum.Deputy) || player.Is(RoleEnum.Jailor) || player.Is(RoleEnum.Juggernaut)
                 || player.Is(RoleEnum.Sheriff) || player.Is(RoleEnum.Vigilante) || player.Is(RoleEnum.Warlock) || player.Is(RoleEnum.Detonator))
                return "(Bomber, Deputy, Jailor, Juggernaut, Sheriff, Vigilante, Warlock or Detonator)";
            else if (player.Is(RoleEnum.Crewmate) || player.Is(RoleEnum.Impostor))
                return "(Crewmate or Impostor)";
            else return "Error";
        }
    }
}