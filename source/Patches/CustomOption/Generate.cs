using System;
using Rewired.UI.ControlMapper;
using TownOfUs.NeutralRoles.DoomsayerMod;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption AurialOn;
        public static CustomNumberOption DetectiveOn;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption LookoutOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption OracleOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption DeputyOn;
        public static CustomNumberOption HunterOn;
        public static CustomNumberOption JailorOn;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;
        public static CustomNumberOption WardenOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption ImitatorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption PoliticianOn;
        public static CustomNumberOption ProsecutorOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption ShifterOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ForetellerOn;
        public static CustomNumberOption DoomsayerOn;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;
        public static CustomNumberOption SoulCollectorOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption JuggernautOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomHeaderOption Speedrunner;
        public static CustomNumberOption SpeedrunnerOn;
        public static CustomNumberOption SpeedrunnerTasksRemaining;
        public static CustomNumberOption SpeedrunnerCommonTask;
        public static CustomNumberOption SpeedrunnerShortTask;
        public static CustomNumberOption SpeedrunnerLongTask;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption JackalOn;
        public static CustomNumberOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption EscapistOn;
        public static CustomNumberOption GrenadierOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption CamouflagerOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption VenererOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption BomberOn;
        public static CustomNumberOption ScavengerOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption WarlockOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption HypnotistOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption AftermathOn;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption FrostyOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption DrunkOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption MiniOn;
        public static CustomNumberOption RadarOn;
        public static CustomNumberOption ShyOn;
        public static CustomNumberOption SixthSenseOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption SaboteurOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapFungle;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomNumberOption RandomMapLevelImpostor;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption CommsDisableTasks;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption CamoCommsKillAnyone;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;
        public static CustomToggleOption FirstDeathShield;
        public static CustomToggleOption NeutralEvilWinEndsGame;
        public static CustomToggleOption CrewKillersContinue;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption DraftModeHeader;
        public static CustomToggleOption DraftEnabled;
        public static CustomToggleOption RandomButtonEnabled;
        public static CustomToggleOption RandomBasesOffChoices;
        public static CustomNumberOption PickTime;
        public static CustomNumberOption ButtonAmount;

        public static CustomHeaderOption RoleListSettings;
        public static CustomToggleOption UniqueRoles;
        public static CustomToggleOption SyzyfowyAmong;
        public static CustomStringOption Slot1;
        public static CustomStringOption Slot2;
        public static CustomStringOption Slot3;
        public static CustomStringOption Slot4;
        public static CustomStringOption Slot5;
        public static CustomStringOption Slot6;
        public static CustomStringOption Slot7;
        public static CustomStringOption Slot8;
        public static CustomStringOption Slot9;
        public static CustomStringOption Slot10;
        public static CustomStringOption Slot11;
        public static CustomStringOption Slot12;
        public static CustomStringOption Slot13;
        public static CustomStringOption Slot14;
        public static CustomStringOption Slot15;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;
        public static CustomNumberOption MayorMaximumBank;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsNE;
        public static CustomToggleOption SheriffKillsNK;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;

        public static CustomHeaderOption Shifter;
        public static CustomNumberOption ShifterCd;
        public static CustomStringOption WhoShifts;
        public static CustomStringOption ShiftedBecomes;
        public static CustomToggleOption ShifterCrewmate;
        public static CustomToggleOption ShifterShiftsModifiers;
        public static CustomToggleOption ShiftHappensOnMeeting;

        public static CustomHeaderOption Evoker;
        public static CustomNumberOption EvokerOn;
        public static CustomNumberOption EvokerCooldown;
        public static CustomNumberOption EvokerDuration;

        public static CustomHeaderOption Conserver;
        public static CustomNumberOption ConserverOn;
        public static CustomToggleOption AllSeeSealedVents;

        public static CustomHeaderOption Security;
        public static CustomNumberOption SecurityOn;
        public static CustomNumberOption CamAmount;

        public static CustomHeaderOption Detonator;
        public static CustomNumberOption DetonatorOn;
        public static CustomNumberOption DetonatorPlantCooldown;
        public static CustomNumberOption DetonatorDetonateCooldown;
        public static CustomNumberOption DetonatorMaxKillsInDetonation;
        public static CustomNumberOption DetonatorRadius;

        public static CustomHeaderOption Disorienter;
        public static CustomNumberOption DisorienterOn;
        public static CustomNumberOption DisorientCooldown;
        public static CustomNumberOption DisorientTime;

        public static CustomHeaderOption Hunter;
        public static CustomNumberOption HunterKillCd;
        public static CustomNumberOption HunterStalkCd;
        public static CustomNumberOption HunterStalkDuration;
        public static CustomNumberOption HunterStalkUses;
        public static CustomToggleOption RetributionOnVote;
        public static CustomToggleOption HunterBodyReport;

        public static CustomHeaderOption Engineer;
        public static CustomNumberOption MaxFixes;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerCanKill;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Spy;
        public static CustomStringOption WhoSeesDead;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterImpVision;
        public static CustomToggleOption JesterHaunt;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Juggernaut;
        public static CustomNumberOption JuggKillCooldown;
        public static CustomNumberOption ReducedKCdPerKill;
        public static CustomToggleOption JuggVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Camouflager;
        public static CustomNumberOption CamouflagerCooldown;
        public static CustomNumberOption CamouflagerDuration;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;
        public static CustomToggleOption ExecutionerTorment;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;
        public static CustomToggleOption PhantomSpook;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;
        public static CustomToggleOption IgniteCdRemoved;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomNumberOption UndertakerDragSpeed;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessModifiers;
        public static CustomToggleOption VigilanteGuessLovers;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption TrackDuration;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;
        public static CustomNumberOption EvilTargetPercent;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;
        public static CustomToggleOption BlackmailInvisible;
        public static CustomNumberOption LatestNonVote;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption ExamineCooldown;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Imitator;
        public static CustomToggleOption ImitatorCanBecomePresident;

        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Bomber;
        public static CustomNumberOption MaxKillsInDetonation;
        public static CustomNumberOption DetonateDelay;
        public static CustomNumberOption DetonateRadius;
        public static CustomToggleOption BomberVent;
        public static CustomToggleOption AllImpsSeeBomb;

        public static CustomHeaderOption Doomsayer;
        public static CustomNumberOption ObserveCooldown;
        public static CustomToggleOption DoomsayerGuessNeutralBenign;
        public static CustomToggleOption DoomsayerGuessNeutralEvil;
        public static CustomToggleOption DoomsayerGuessNeutralKilling;
        public static CustomToggleOption DoomsayerGuessImpostors;
        public static CustomToggleOption DoomsayerCantObserve;

        public static CustomHeaderOption Foreteller;
        public static CustomNumberOption ForetellerObserveCooldown;
        public static CustomToggleOption ForetellerGuessNeutralBenign;
        public static CustomToggleOption ForetellerGuessNeutralEvil;
        public static CustomToggleOption ForetellerGuessNeutralKilling;
        public static CustomToggleOption ForetellerGuessImpostors;
        public static CustomToggleOption ForetellerAfterVoting;
        public static CustomNumberOption ForetellerGuessesToWin;
        public static CustomToggleOption ForetellerCantObserve;

        public static CustomHeaderOption Jackal;
        public static CustomNumberOption BiteCooldown;
        public static CustomNumberOption LightCooldown;
        public static CustomToggleOption VampImpVision;
        public static CustomToggleOption VampVent;
        public static CustomToggleOption NewVampCanAssassin;
        public static CustomNumberOption MaxVampiresPerGame;
        public static CustomToggleOption CanBiteNeutralBenign;
        public static CustomToggleOption CanBiteNeutralEvil;
        public static CustomToggleOption CanBiteImpostors;

        public static CustomHeaderOption Prosecutor;
        public static CustomToggleOption ProsDiesOnIncorrectPros;

        public static CustomHeaderOption Warlock;
        public static CustomNumberOption ChargeUpDuration;
        public static CustomNumberOption ChargeUseDuration;

        public static CustomHeaderOption Oracle;
        public static CustomNumberOption ConfessCooldown;
        public static CustomNumberOption RevealAccuracy;
        public static CustomToggleOption NeutralBenignShowsEvil;
        public static CustomToggleOption NeutralEvilShowsEvil;
        public static CustomToggleOption NeutralKillingShowsEvil;


        public static CustomHeaderOption Deputy;


        public static CustomHeaderOption Warden;

        public static CustomHeaderOption Janitor;
        public static CustomHeaderOption Venerer;
        public static CustomNumberOption AbilityCooldown;
        public static CustomNumberOption AbilityDuration;
        public static CustomNumberOption SprintSpeed;
        public static CustomNumberOption FreezeSpeed;

        public static CustomHeaderOption Aurial;
        public static CustomNumberOption AuraInnerRadius;
        public static CustomNumberOption AuraOuterRadius;
        public static CustomNumberOption SenseDuration;

        public static CustomHeaderOption Politician;
        public static CustomNumberOption CampaignCooldown;

        public static CustomHeaderOption Hypnotist;
        public static CustomNumberOption HypnotiseCooldown;

        public static CustomHeaderOption Jailor;
        public static CustomNumberOption JailCooldown;
        public static CustomNumberOption MaxExecutes;

        public static CustomHeaderOption SoulCollector;
        public static CustomNumberOption ReapCooldown;
        public static CustomToggleOption PassiveSoulCollection;
        public static CustomNumberOption SoulsToWin;

        public static CustomHeaderOption Lookout;
        public static CustomNumberOption WatchCooldown;
        public static CustomToggleOption LoResetOnNewRound;
        public static CustomNumberOption MaxWatches;

        public static CustomHeaderOption Scavenger;
        public static CustomNumberOption ScavengeDuration;
        public static CustomNumberOption ScavengeIncreaseDuration;
        public static CustomNumberOption ScavengeCorrectKillCooldown;
        public static CustomNumberOption ScavengeIncorrectKillCooldown;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;
        public static CustomToggleOption ImpLoverKillTeammate;

        public static CustomHeaderOption Frosty;
        public static CustomNumberOption ChillDuration;
        public static CustomNumberOption ChillStartSpeed;

        public static CustomHeaderOption Shy;
        public static CustomNumberOption InvisDelay;
        public static CustomNumberOption TransformInvisDuration;
        public static CustomNumberOption FinalTransparency;

        public static CustomHeaderOption Saboteur;
        public static CustomNumberOption ReducedSaboCooldown;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            //var num = 0;

            //CrewInvestigativeRoles = new CustomHeaderOption((int)SettingsEnum.CrewInvestigativeRoles, MultiMenu.crewmate, "Crewmate Investigative Roles");
            //CrewKillingRoles = new CustomHeaderOption((int)SettingsEnum.CrewKillingRoles, MultiMenu.crewmate, "Crewmate Killing Roles"); 
            //CrewProtectiveRoles = new CustomHeaderOption((int)SettingsEnum.CrewProtectiveRoles, MultiMenu.crewmate, "Crewmate Protective Roles");
            //CrewSupportRoles = new CustomHeaderOption((int)SettingsEnum.CrewSupportRoles, MultiMenu.crewmate, "Crewmate Support Roles");

            Mayor = new CustomHeaderOption((int)SettingsEnum.Mayor, MultiMenu.crewmate, "<color=#704FA8FF><b>Mayor</b></color>");
            MayorOn = new CustomNumberOption((int)SettingsEnum.MayorOn, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MayorVoteBank = new CustomNumberOption((int)SettingsEnum.MayorVoteBank, MultiMenu.crewmate, "Initial Mayor Vote Bank", 1, 0, 15, 1);
            MayorAnonymous = new CustomToggleOption((int)SettingsEnum.MayorAnonymous, MultiMenu.crewmate, "Mayor Votes Show Anonymous", false);
            MayorMaximumBank = new CustomNumberOption((int)SettingsEnum.MayorMaximumBank, MultiMenu.crewmate, "The Maximum Amount Of Votes In The Vote Bank", 3, 2, 20, 1);

            Politician = new CustomHeaderOption((int)SettingsEnum.Politician, MultiMenu.crewmate, "<color=#660099FF><b>Politician</b></color>");
            PoliticianOn = new CustomNumberOption((int)SettingsEnum.PoliticianOn, MultiMenu.crewmate, "<color=#660099FF>Politician</color>", 0f, 0f, 100f, 10f, PercentFormat);
            CampaignCooldown = new CustomNumberOption((int)SettingsEnum.CampaignCooldown, MultiMenu.crewmate, "Campaign Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Prosecutor = new CustomHeaderOption((int)SettingsEnum.Prosecutor, MultiMenu.crewmate, "<color=#B38000FF><b>Prosecutor</b></color>");
            ProsecutorOn = new CustomNumberOption((int)SettingsEnum.ProsecutorOn, MultiMenu.crewmate, "<color=#B38000FF>Prosecutor</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ProsDiesOnIncorrectPros = new CustomToggleOption((int)SettingsEnum.ProsDiesOnIncorrectPros, MultiMenu.crewmate, "Prosecutor Dies When They Exile A Crewmate", false);

            Sheriff = new CustomHeaderOption((int)SettingsEnum.Sheriff, MultiMenu.crewmate, "<color=#FFFF00FF><b>Sheriff</b></color>");
            SheriffOn = new CustomNumberOption((int)SettingsEnum.SheriffOn, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SheriffKillOther = new CustomToggleOption((int)SettingsEnum.SheriffKillOther, MultiMenu.crewmate, "Sheriff Miskill Kills Crewmate", false);
            SheriffKillsNE = new CustomToggleOption((int)SettingsEnum.SheriffKillsNE, MultiMenu.crewmate, "Sheriff Kills Neutral Evil Roles", false);
            SheriffKillsNK = new CustomToggleOption((int)SettingsEnum.SheriffKillsNK, MultiMenu.crewmate, "Sheriff Kills Neutral Killing Roles", false);
            SheriffKillCd = new CustomNumberOption((int)SettingsEnum.SheriffKillCd, MultiMenu.crewmate, "Sheriff Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption((int)SettingsEnum.SheriffBodyReport, MultiMenu.crewmate, "Sheriff Can Report Who They've Killed");

            Veteran = new CustomHeaderOption((int)SettingsEnum.Veteran, MultiMenu.crewmate, "<color=#998040FF><b>Veteran</b></color>");
            VeteranOn = new CustomNumberOption((int)SettingsEnum.VeteranOn, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>", 0f, 0f, 100f, 10f, PercentFormat);
            KilledOnAlert = new CustomToggleOption((int)SettingsEnum.KilledOnAlert, MultiMenu.crewmate, "Can Be Killed On Alert", false);
            AlertCooldown = new CustomNumberOption((int)SettingsEnum.AlertCooldown, MultiMenu.crewmate, "Alert Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration = new CustomNumberOption((int)SettingsEnum.AlertDuration, MultiMenu.crewmate, "Alert Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption((int)SettingsEnum.MaxAlerts, MultiMenu.crewmate, "Maximum Number Of Alerts", 5, 1, 15, 1);

            Engineer = new CustomHeaderOption((int)SettingsEnum.Engineer, MultiMenu.crewmate, "<color=#FFA60AFF><b>Engineer</b></color>");
            EngineerOn = new CustomNumberOption((int)SettingsEnum.EngineerOn, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MaxFixes = new CustomNumberOption((int)SettingsEnum.MaxFixes, MultiMenu.crewmate, "Maximum Number Of Fixes", 5, 1, 15, 1);

            Conserver = new CustomHeaderOption((int)SettingsEnum.Conserver, MultiMenu.crewmate, "<color=#FF8000FF><b>Conserver</b></color>");
            ConserverOn = new CustomNumberOption((int)SettingsEnum.ConserverOn, MultiMenu.crewmate, "<color=#FF8000FF>Conserver</color>", 0f, 0f, 100f, 10f, PercentFormat);
            AllSeeSealedVents = new CustomToggleOption((int)SettingsEnum.AllSeeSealedVents, MultiMenu.crewmate, "All people see sealed vents", false);

            Swapper = new CustomHeaderOption((int)SettingsEnum.Swapper, MultiMenu.crewmate, "<color=#66E666FF><b>Swapper</b></color>");
            SwapperOn = new CustomNumberOption((int)SettingsEnum.SwapperOn, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SwapperButton = new CustomToggleOption((int)SettingsEnum.SwapperButton, MultiMenu.crewmate, "Swapper Can Button", true);

            Detective = new CustomHeaderOption((int)SettingsEnum.Detective, MultiMenu.crewmate, "<color=#4D4DFFFF><b>Detective</b></color>");
            DetectiveOn = new CustomNumberOption((int)SettingsEnum.DetectiveOn, MultiMenu.crewmate, "<color=#4D4DFFFF>Detective</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ExamineCooldown = new CustomNumberOption((int)SettingsEnum.ExamineCooldown, MultiMenu.crewmate, "Examine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption((int)SettingsEnum.DetectiveReportOn, MultiMenu.crewmate, "Show Detective Reports", true);
            DetectiveRoleDuration = new CustomNumberOption((int)SettingsEnum.DetectiveRoleDuration, MultiMenu.crewmate, "Time Where Detective Will Have Role", 15f, 0f, 60f, 2.5f, CooldownFormat);
            DetectiveFactionDuration = new CustomNumberOption((int)SettingsEnum.DetectiveFactionDuration, MultiMenu.crewmate, "Time Where Detective Will Have Faction", 30f, 0f, 60f, 2.5f, CooldownFormat);

            Investigator = new CustomHeaderOption((int)SettingsEnum.Investigator, MultiMenu.crewmate, "<color=#00B3B3FF><b>Investigator</b></color>");
            InvestigatorOn = new CustomNumberOption((int)SettingsEnum.InvestigatorOn, MultiMenu.crewmate, "<color=#00B3B3FF>Investigator</color>", 0f, 0f, 100f, 10f, PercentFormat);
            FootprintSize = new CustomNumberOption((int)SettingsEnum.FootprintSize, MultiMenu.crewmate, "Footprint Size", 4f, 1f, 10f, 1f);
            FootprintInterval = new CustomNumberOption((int)SettingsEnum.FootprintInterval, MultiMenu.crewmate, "Footprint Interval", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption((int)SettingsEnum.FootprintDuration, MultiMenu.crewmate, "Footprint Duration", 10f, 1f, 15f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption((int)SettingsEnum.AnonymousFootPrint, MultiMenu.crewmate, "Anonymous Footprint", false);
            VentFootprintVisible = new CustomToggleOption((int)SettingsEnum.VentFootprintVisible, MultiMenu.crewmate, "Footprint Vent Visible", false);

            Security = new CustomHeaderOption((int)SettingsEnum.Security, MultiMenu.crewmate, "<color=#CCFFFFFF><b>Security</b></color>");
            SecurityOn = new CustomNumberOption((int)SettingsEnum.SecurityOn, MultiMenu.crewmate, "<color=#CCFFFFFF>Security</color>", 0f, 0f, 100f, 10f, PercentFormat);
            CamAmount = new CustomNumberOption((int)SettingsEnum.CamAmount, MultiMenu.crewmate, "How many Cams can Security place", 3, 1, 5, 1);
            
            Tracker = new CustomHeaderOption((int)SettingsEnum.Tracker, MultiMenu.crewmate, "<color=#009900FF><b>Tracker</b></color>");
            TrackerOn = new CustomNumberOption((int)SettingsEnum.TrackerOn, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>", 0f, 0f, 100f, 10f, PercentFormat);
            //UpdateInterval = new CustomNumberOption((int)SettingsEnum.UpdateInterval, MultiMenu.crewmate, "Minimap update interval (does not work)", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown = new CustomNumberOption((int)SettingsEnum.TrackCooldown, MultiMenu.crewmate, "Track Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TrackDuration = new CustomNumberOption((int)SettingsEnum.TrackDuration, MultiMenu.crewmate, "Tracking Duration (does not work)", 30f, 10f, 60f, 5f, CooldownFormat);

            Trapper = new CustomHeaderOption((int)SettingsEnum.Trapper, MultiMenu.crewmate, "<color=#A7D1B3FF><b>Trapper</b></color>");
            TrapperOn = new CustomNumberOption((int)SettingsEnum.TrapperOn, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MinAmountOfTimeInTrap = new CustomNumberOption((int)SettingsEnum.MinAmountOfTimeInTrap, MultiMenu.crewmate, "Min Amount Of Time In Trap To Register", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown = new CustomNumberOption((int)SettingsEnum.TrapCooldown, MultiMenu.crewmate, "Trap Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound = new CustomToggleOption((int)SettingsEnum.TrapsRemoveOnNewRound, MultiMenu.crewmate, "Traps Removed After Each Round", true);
            MaxTraps = new CustomNumberOption((int)SettingsEnum.MaxTraps, MultiMenu.crewmate, "Maximum Number Of Traps", 5, 1, 15, 1);
            TrapSize = new CustomNumberOption((int)SettingsEnum.TrapSize, MultiMenu.crewmate, "Trap Size", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            MinAmountOfPlayersInTrap = new CustomNumberOption((int)SettingsEnum.MinAmountOfPlayersInTrap, MultiMenu.crewmate, "Minimum Number Of Roles Required To Trigger Trap", 3, 1, 5, 1);

            TimeLord = new CustomHeaderOption((int)SettingsEnum.TimeLord, MultiMenu.crewmate, "<color=#0000FFFF></b>Time Lord</b></color>");
            TimeLordOn = new CustomNumberOption((int)SettingsEnum.TimeLordOn, MultiMenu.crewmate, "<color=#0000FFFF>Time Lord</color>", 0f, 0f, 100f, 10f, PercentFormat);
            RewindRevive = new CustomToggleOption((int)SettingsEnum.RewindRevive, MultiMenu.crewmate, "Revive During Rewind", false);
            RewindDuration = new CustomNumberOption((int)SettingsEnum.RewindDuration, MultiMenu.crewmate, "Rewind Duration", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption((int)SettingsEnum.RewindCooldown, MultiMenu.crewmate, "Rewind Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses = new CustomNumberOption((int)SettingsEnum.RewindMaxUses, MultiMenu.crewmate, "Maximum Number Of Rewinds", 5, 1, 15, 1);
            TimeLordVitals = new CustomToggleOption((int)SettingsEnum.TimeLordVitals, MultiMenu.crewmate, "Time Lord Can Use Vitals", false);

            Transporter = new CustomHeaderOption((int)SettingsEnum.Transporter, MultiMenu.crewmate, "<color=#00EEFFFF><b>Transporter</b></color>");
            TransporterOn = new CustomNumberOption((int)SettingsEnum.TransporterOn, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>", 0f, 0f, 100f, 10f, PercentFormat);
            TransportCooldown = new CustomNumberOption((int)SettingsEnum.TransportCooldown, MultiMenu.crewmate, "Transport Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses = new CustomNumberOption((int)SettingsEnum.TransportMaxUses, MultiMenu.crewmate, "Maximum Number Of Transports", 5, 1, 15, 1);
            TransporterVitals = new CustomToggleOption((int)SettingsEnum.TransporterVitals, MultiMenu.crewmate, "Transporter Can Use Vitals", false);
  
            Medic = new CustomHeaderOption((int)SettingsEnum.Medic, MultiMenu.crewmate, "<color=#006600FF><b>Medic</b></color>");
            MedicOn = new CustomNumberOption((int)SettingsEnum.MedicOn, MultiMenu.crewmate, "<color=#006600FF>Medic</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ShowShielded = new CustomStringOption((int)SettingsEnum.ShowShielded, MultiMenu.crewmate, "Show Shielded Player",     new[] { "Self", "Medic", "Self+Medic", "Everyone" });
            WhoGetsNotification = new CustomStringOption((int)SettingsEnum.WhoGetsNotification, MultiMenu.crewmate, "Who Gets Murder Attempt Indicator",     new[] { "Medic", "Shielded", "Everyone", "Nobody" });
            ShieldBreaks = new CustomToggleOption((int)SettingsEnum.ShieldBreaks, MultiMenu.crewmate, "Shield Breaks On Murder Attempt", false);
            MedicReportSwitch = new CustomToggleOption((int)SettingsEnum.MedicReportSwitch, MultiMenu.crewmate, "Show Medic Reports");
            MedicReportNameDuration = new CustomNumberOption((int)SettingsEnum.MedicReportNameDuration, MultiMenu.crewmate, "Time Where Medic Will Have Name", 0f, 0f, 60f, 2.5f,     CooldownFormat);
            MedicReportColorDuration = new CustomNumberOption((int)SettingsEnum.MedicReportColorDuration, MultiMenu.crewmate, "Time Where Medic Will Have Color Type", 15f, 0f, 60f, 2.5f,     CooldownFormat);

            Seer = new CustomHeaderOption((int)SettingsEnum.Seer, MultiMenu.crewmate, "<color=#FFCC80FF><b>Seer</b></color>");
            SeerOn = new CustomNumberOption((int)SettingsEnum.SeerOn, MultiMenu.crewmate, "<color=#FFCC80FF>Seer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SeerCooldown = new CustomNumberOption((int)SettingsEnum.SeerCooldown, MultiMenu.crewmate, "Seer Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed = new CustomToggleOption((int)SettingsEnum.CrewKillingRed, MultiMenu.crewmate, "Crewmate Killing Roles Are Red", false);
            NeutBenignRed = new CustomToggleOption((int)SettingsEnum.NeutBenignRed, MultiMenu.crewmate, "Neutral Benign Roles Are Red", false);
            NeutEvilRed = new CustomToggleOption((int)SettingsEnum.NeutEvilRed, MultiMenu.crewmate, "Neutral Evil Roles Are Red", false);
            NeutKillingRed = new CustomToggleOption((int)SettingsEnum.NeutKillingRed, MultiMenu.crewmate, "Neutral Killing Roles Are Red", true);
            TraitorColourSwap = new CustomToggleOption((int)SettingsEnum.TraitorColourSwap, MultiMenu.crewmate, "Traitor Does Not Swap Colours", false);
        
            Spy = new CustomHeaderOption((int)SettingsEnum.Spy, MultiMenu.crewmate, "<color=#CCA3CCFF><b>Spy</b></color>");
            SpyOn = new CustomNumberOption((int)SettingsEnum.SpyOn, MultiMenu.crewmate, "<color=#CCA3CCFF>Spy</color>", 0f, 0f, 100f, 10f, PercentFormat);
            WhoSeesDead = new CustomStringOption((int)SettingsEnum.WhoSeesDead, MultiMenu.crewmate, "Who Sees Dead Bodies On Admin",  new[] { "Nobody", "Spy", "Everyone But Spy", "Everyone" });

            Snitch = new CustomHeaderOption((int)SettingsEnum.Snitch, MultiMenu.crewmate, "<color=#D4AF37FF><b>Snitch</b></color>");
            SnitchOn = new CustomNumberOption((int)SettingsEnum.SnitchOn, MultiMenu.crewmate, "<color=#D4AF37FF>Snitch</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SnitchSeesNeutrals = new CustomToggleOption((int)SettingsEnum.SnitchSeesNeutrals, MultiMenu.crewmate, "Snitch Sees Neutral Roles", false);
            SnitchTasksRemaining = new CustomNumberOption((int)SettingsEnum.SnitchTasksRemaining, MultiMenu.crewmate, "Tasks Remaining When Revealed", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption((int)SettingsEnum.SnitchSeesImpInMeeting, MultiMenu.crewmate, "Snitch Sees Impostors In Meetings", true);
            SnitchSeesTraitor = new CustomToggleOption((int)SettingsEnum.SnitchSeesTraitor, MultiMenu.crewmate, "Snitch Sees Traitor", true);
         
            Imitator = new CustomHeaderOption((int)SettingsEnum.Imitator, MultiMenu.crewmate, "<color=#B3D94DFF><b>Imitator</b></color>");
            ImitatorOn = new CustomNumberOption((int)SettingsEnum.ImitatorOn, MultiMenu.crewmate, "<color=#B3D94DFF>Imitator</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ImitatorCanBecomePresident = new CustomToggleOption((int)SettingsEnum.ImitatorCanBecomePresident, MultiMenu.crewmate, "Imitator Can Become President", true);
           
            Altruist = new CustomHeaderOption((int)SettingsEnum.Altruist, MultiMenu.crewmate, "<color=#660000FF><b>Altruist</b></color>");
            AltruistOn = new CustomNumberOption((int)SettingsEnum.AltruistOn, MultiMenu.crewmate, "<color=#660000FF>Altruist</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ReviveDuration = new CustomNumberOption((int)SettingsEnum.ReviveDuration, MultiMenu.crewmate, "Altruist Revive Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody = new CustomToggleOption((int)SettingsEnum.AltruistTargetBody, MultiMenu.crewmate, "Target's Body Disappears On Beginning Of Revive", false);

            Medium = new CustomHeaderOption((int)SettingsEnum.Medium, MultiMenu.crewmate, "<color=#A680FFFF><b>Medium</b></color>");
            MediumOn = new CustomNumberOption((int)SettingsEnum.MediumOn, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MediateCooldown = new CustomNumberOption((int)SettingsEnum.MediateCooldown, MultiMenu.crewmate, "Mediate Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer = new CustomToggleOption((int)SettingsEnum.ShowMediatePlayer, MultiMenu.crewmate, "Reveal Appearance Of Mediate Target", true);
            ShowMediumToDead = new CustomToggleOption((int)SettingsEnum.ShowMediumToDead, MultiMenu.crewmate, "Reveal The Medium To The Mediate Target", true);
            DeadRevealed = new CustomStringOption((int)SettingsEnum.DeadRevealed, MultiMenu.crewmate, "Who Is Revealed With Mediate", new[] { "Oldest Dead", "Newest Dead", "All Dead" });

            Evoker = new CustomHeaderOption((int)SettingsEnum.Evoker, MultiMenu.crewmate, "<color=#000080FF><b>Evoker</b></color>");
            EvokerOn = new CustomNumberOption((int)SettingsEnum.EvokerOn, MultiMenu.crewmate, "<color=#000080FF>Evoker</color>", 0f, 0f, 100f, 10f, PercentFormat);
            EvokerCooldown = new CustomNumberOption((int)SettingsEnum.EvokerCooldown, MultiMenu.crewmate, "Blind Cooldown", 40f, 20f, 60f, 5f, CooldownFormat);
            EvokerDuration = new CustomNumberOption((int)SettingsEnum.EvokerDuration, MultiMenu.crewmate, "Blindness duration", 20f, 10f, 35f, 2.5f, CooldownFormat);

            Jailor = new CustomHeaderOption((int)SettingsEnum.Jailor, MultiMenu.crewmate, "<color=#A6A6A6FF><b>Jailor</b></color>");
            JailorOn = new CustomNumberOption((int)SettingsEnum.JailorOn, MultiMenu.crewmate, "<color=#A6A6A6FF>Jailor</color>", 0f, 0f, 100f, 10f, PercentFormat);
            JailCooldown = new CustomNumberOption((int)SettingsEnum.JailCooldown, MultiMenu.crewmate, "Jail Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxExecutes = new CustomNumberOption((int)SettingsEnum.MaxExecutes, MultiMenu.crewmate, "Maximum Number Of Executes", 3, 1, 5, 1);

            Vigilante = new CustomHeaderOption((int)SettingsEnum.Vigilante, MultiMenu.crewmate, "<color=#FFFF99FF><b>Vigilante</b></color>");
            VigilanteOn = new CustomNumberOption((int)SettingsEnum.VigilanteOn, MultiMenu.crewmate, "<color=#FFFF99FF>Vigilante</color>", 0f, 0f, 100f, 10f, PercentFormat);
            VigilanteKills = new CustomNumberOption((int)SettingsEnum.VigilanteKills, MultiMenu.crewmate, "Number Of Vigilante Kills", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption((int)SettingsEnum.VigilanteMultiKill, MultiMenu.crewmate, "Vigilante Can Kill More Than Once Per Meeting", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption((int)SettingsEnum.VigilanteGuessNeutralBenign, MultiMenu.crewmate, "Vigilante Can Guess Neutral Benign Roles", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption((int)SettingsEnum.VigilanteGuessNeutralEvil, MultiMenu.crewmate, "Vigilante Can Guess Neutral Evil Roles", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption((int)SettingsEnum.VigilanteGuessNeutralKilling, MultiMenu.crewmate, "Vigilante Can Guess Neutral Killing Roles", false);
            VigilanteGuessModifiers = new CustomToggleOption((int)SettingsEnum.VigilanteGuessModifiers, MultiMenu.crewmate, "Vigilante Can Guess Impostor Modifiers", false);
            VigilanteGuessLovers = new CustomToggleOption((int)SettingsEnum.VigilanteGuessLovers, MultiMenu.crewmate, "Vigilante Can Guess Lovers", false);

            Mystic = new CustomHeaderOption((int)SettingsEnum.Mystic, MultiMenu.crewmate, "<color=#4D99E6FF><b>Mystic</b></color>");
            MysticOn = new CustomNumberOption((int)SettingsEnum.MysticOn, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MysticArrowDuration = new CustomNumberOption((int)SettingsEnum.MysticArrowDuration, MultiMenu.crewmate, "Dead Body Arrow Duration", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Aurial = new CustomHeaderOption((int)SettingsEnum.Aurial, MultiMenu.crewmate, "<color=#B34D99FF><b>Aurial</b></color>");
            AurialOn = new CustomNumberOption((int)SettingsEnum.AurialOn, MultiMenu.crewmate, "<color=#B34D99FF>Aurial</color>", 0f, 0f, 100f, 10f, PercentFormat);
            AuraInnerRadius = new CustomNumberOption((int)SettingsEnum.AuraInnerRadius, MultiMenu.crewmate, "Radiate Colour Range", 0.5f, 0f, 1f, 0.25f, MultiplierFormat);
            AuraOuterRadius = new CustomNumberOption((int)SettingsEnum.AuraOuterRadius, MultiMenu.crewmate, "Radiate Max Range", 1.5f, 1f, 5f, 0.25f, MultiplierFormat);
            SenseDuration = new CustomNumberOption((int)SettingsEnum.SenseDuration, MultiMenu.crewmate, "Sense Duration", 10f, 1f, 15f, 1f, CooldownFormat);

            Oracle = new CustomHeaderOption((int)SettingsEnum.Oracle, MultiMenu.crewmate, "<color=#BF00BFFF><b>Oracle</b></color>");
            OracleOn = new CustomNumberOption((int)SettingsEnum.OracleOn, MultiMenu.crewmate, "<color=#BF00BFFF>Oracle</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ConfessCooldown = new CustomNumberOption((int)SettingsEnum.ConfessCooldown, MultiMenu.crewmate, "Confess Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RevealAccuracy = new CustomNumberOption((int)SettingsEnum.RevealAccuracy, MultiMenu.crewmate, "Reveal Accuracy", 80f, 0f, 100f, 10f, PercentFormat);
            NeutralBenignShowsEvil = new CustomToggleOption((int)SettingsEnum.NeutralBenignShowsEvil, MultiMenu.crewmate, "Neutral Benign Roles Show Evil", false);
            NeutralEvilShowsEvil = new CustomToggleOption((int)SettingsEnum.NeutralEvilShowsEvil, MultiMenu.crewmate, "Neutral Evil Roles Show Evil", false);
            NeutralKillingShowsEvil = new CustomToggleOption((int)SettingsEnum.NeutralKillingShowsEvil, MultiMenu.crewmate, "Neutral Killing Roles Show Evil", true);

            Hunter = new CustomHeaderOption((int)SettingsEnum.Hunter, MultiMenu.crewmate, "<color=#29AB87FF><b>Hunter</b></color>");
            HunterOn = new CustomNumberOption((int)SettingsEnum.HunterOn, MultiMenu.crewmate, "<color=#29AB87FF>Hunter</color>", 0f, 0f, 100f, 10f, PercentFormat);
            HunterKillCd = new CustomNumberOption((int)SettingsEnum.HunterKillCd, MultiMenu.crewmate, "Hunter Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HunterStalkCd = new CustomNumberOption((int)SettingsEnum.HunterStalkCd, MultiMenu.crewmate, "Hunter Stalk Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            HunterStalkDuration = new CustomNumberOption((int)SettingsEnum.HunterStalkDuration, MultiMenu.crewmate, "Hunter Stalk Duration", 25f, 5f, 60f, 2.5f, CooldownFormat);
            HunterStalkUses = new CustomNumberOption((int)SettingsEnum.HunterStalkUses, MultiMenu.crewmate, "Maximum Stalk Uses", 5, 1, 15, 1);
            RetributionOnVote = new CustomToggleOption((int)SettingsEnum.RetributionOnVote, MultiMenu.crewmate, "Hunter Kills Last Voter If Voted Out", false);
            HunterBodyReport = new CustomToggleOption((int)SettingsEnum.HunterBodyReport, MultiMenu.crewmate, "Hunter Can Report Who They've Killed");

            Haunter = new CustomHeaderOption((int)SettingsEnum.Haunter, MultiMenu.crewmate, "<color=#D3D3D3FF><b>Haunter</b></color>");
            HaunterOn = new CustomNumberOption((int)SettingsEnum.HaunterOn, MultiMenu.crewmate, "<color=#D3D3D3FF>Haunter</color>", 0f, 0f, 100f, 10f, PercentFormat); 
            HaunterTasksRemainingClicked = new CustomNumberOption((int)SettingsEnum.HaunterTasksRemainingClicked, MultiMenu.crewmate, "Tasks Remaining When Haunter Can Be Clicked", 5, 1, 15, 1);
            HaunterTasksRemainingAlert = new CustomNumberOption((int)SettingsEnum.HaunterTasksRemainingAlert, MultiMenu.crewmate, "Tasks Remaining When Alert Is Sent", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption((int)SettingsEnum.HaunterRevealsNeutrals, MultiMenu.crewmate, "Haunter Reveals Neutral Roles", false);
            HaunterCanBeClickedBy = new CustomStringOption((int)SettingsEnum.HaunterCanBeClickedBy, MultiMenu.crewmate, "Who Can Click Haunter", new[] { "All", "Non-Crew", "Imps Only" });

            Lookout = new CustomHeaderOption((int)SettingsEnum.Lookout, MultiMenu.crewmate, "<color=#33FF66FF><b>Lookout</b></color>");
            LookoutOn = new CustomNumberOption((int)SettingsEnum.LookoutOn, MultiMenu.crewmate, "<color=#33FF66FF>Lookout</color>", 0f, 0f, 100f, 10f, PercentFormat);
            WatchCooldown = new CustomNumberOption((int)SettingsEnum.WatchCooldown, MultiMenu.crewmate, "Watch Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            LoResetOnNewRound = new CustomToggleOption((int)SettingsEnum.LoResetOnNewRound, MultiMenu.crewmate, "Lookout Watches Reset After Each Round", true);
            MaxWatches = new CustomNumberOption((int)SettingsEnum.MaxWatches, MultiMenu.crewmate, "Maximum Number Of Players That Can Be Watched", 5, 1, 15, 1);

            Deputy = new CustomHeaderOption((int)SettingsEnum.Deputy, MultiMenu.crewmate, "<color=#FFCC00FF><b>Deputy</b></color>");
            DeputyOn = new CustomNumberOption((int)SettingsEnum.DeputyOn, MultiMenu.crewmate, "<color=#FFCC00FF>Deputy</color>", 0f, 0f, 100f, 10f, PercentFormat);

            Warden = new CustomHeaderOption((int)SettingsEnum.Warden, MultiMenu.crewmate, "<color=#9900FFFF><b>Warden</b></color>");
            WardenOn = new CustomNumberOption((int)SettingsEnum.WardenOn, MultiMenu.crewmate, "<color=#9900FFFF>Warden</color>", 0f, 0f, 100f, 10f, PercentFormat);

            //NeutralBenignRoles = new CustomHeaderOption((int)SettingsEnum.NeutralBenignRoles, MultiMenu.neutral, "Neutral Benign Roles");   
            //NeutralEvilRoles = new CustomHeaderOption((int)SettingsEnum.NeutralEvilRoles, MultiMenu.neutral, "Neutral Evil Roles");
            //NeutralKillingRoles = new CustomHeaderOption((int)SettingsEnum.NeutralKillingRoles, MultiMenu.neutral, "Neutral Killing Roles");

            Jester = new CustomHeaderOption((int)SettingsEnum.Jester, MultiMenu.neutral, "<color=#FFBFCCFF><b>Jester</b></color>");
            JesterOn = new CustomNumberOption((int)SettingsEnum.JesterOn, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color>", 0f, 0f, 100f, 10f, PercentFormat);
            JesterButton = new CustomToggleOption((int)SettingsEnum.JesterButton, MultiMenu.neutral, "Jester Can Button", true);
            JesterVent = new CustomToggleOption((int)SettingsEnum.JesterVent, MultiMenu.neutral, "Jester Can Hide In Vents", false);
            JesterImpVision = new CustomToggleOption((int)SettingsEnum.JesterImpVision, MultiMenu.neutral, "Jester Has Impostor Vision", false);
            JesterHaunt = new CustomToggleOption((int)SettingsEnum.JesterHaunt, MultiMenu.neutral, "Jester Haunts Player On Victory", true);

            Executioner = new CustomHeaderOption((int)SettingsEnum.Executioner, MultiMenu.neutral, "<color=#8C4005FF><b>Executioner</b></color>");
            ExecutionerOn = new CustomNumberOption((int)SettingsEnum.ExecutionerOn, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color>", 0f, 0f, 100f, 10f, PercentFormat);
            OnTargetDead = new CustomStringOption((int)SettingsEnum.OnTargetDead, MultiMenu.neutral, "Executioner Becomes On Target Dead", new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            ExecutionerButton = new CustomToggleOption((int)SettingsEnum.ExecutionerButton, MultiMenu.neutral, "Executioner Can Button", true);
            ExecutionerTorment = new CustomToggleOption((int)SettingsEnum.ExecutionerTorment, MultiMenu.neutral, "Executioner Torments Player On Victory", true);

            GuardianAngel = new CustomHeaderOption((int)SettingsEnum.GuardianAngel, MultiMenu.neutral, "<color=#B3FFFFFF><b>Guardian Angel</b></color>");
            GuardianAngelOn = new CustomNumberOption((int)SettingsEnum.GuardianAngelOn, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ProtectCd = new CustomNumberOption((int)SettingsEnum.ProtectCd, MultiMenu.neutral, "Protect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration = new CustomNumberOption((int)SettingsEnum.ProtectDuration, MultiMenu.neutral, "Protect Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset = new CustomNumberOption((int)SettingsEnum.ProtectKCReset, MultiMenu.neutral, "Kill Cooldown Reset When Protected", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects = new CustomNumberOption((int)SettingsEnum.MaxProtects, MultiMenu.neutral, "Maximum Number Of Protects", 5, 1, 15, 1);
            ShowProtect = new CustomStringOption((int)SettingsEnum.ShowProtect, MultiMenu.neutral, "Show Protected Player",     new[] { "Self", "Guardian Angel", "Self+GA", "Everyone" });
            GaOnTargetDeath = new CustomStringOption((int)SettingsEnum.GaOnTargetDeath, MultiMenu.neutral, "GA Becomes On Target Dead", new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            GATargetKnows = new CustomToggleOption((int)SettingsEnum.GATargetKnows, MultiMenu.neutral, "Target Knows GA Exists", false);
            GAKnowsTargetRole = new CustomToggleOption((int)SettingsEnum.GAKnowsTargetRole, MultiMenu.neutral, "GA Knows Targets Role", false);
            EvilTargetPercent = new CustomNumberOption((int)SettingsEnum.EvilTargetPercent, MultiMenu.neutral, "Odds Of Target Being Evil", 20f, 0f, 100f, 10f, PercentFormat);

            Survivor = new CustomHeaderOption((int)SettingsEnum.Survivor, MultiMenu.neutral, "<color=#FFE64DFF><b>Survivor</b></color>");
            SurvivorOn = new CustomNumberOption((int)SettingsEnum.SurvivorOn, MultiMenu.neutral, "<color=#FFE64DFF>Survivor</color>", 0f, 0f, 100f, 10f, PercentFormat);
            VestCd = new CustomNumberOption((int)SettingsEnum.VestCd, MultiMenu.neutral, "Vest Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VestDuration = new CustomNumberOption((int)SettingsEnum.VestDuration, MultiMenu.neutral, "Vest Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            VestKCReset = new CustomNumberOption((int)SettingsEnum.VestKCReset, MultiMenu.neutral, "Kill Cooldown Reset On Attack", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests = new CustomNumberOption((int)SettingsEnum.MaxVests, MultiMenu.neutral, "Maximum Number Of Vests", 5, 1, 15, 1);

            Shifter = new CustomHeaderOption((int)SettingsEnum.Shifter, MultiMenu.neutral, "<color=#999999FF><b>Shifter</b></color>");
            ShifterOn = new CustomNumberOption((int)SettingsEnum.ShifterOn, MultiMenu.neutral, "<color=#999999FF>Shifter</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ShifterCd = new CustomNumberOption((int)SettingsEnum.ShifterCd, MultiMenu.neutral, "Shifter Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            WhoShifts = new CustomStringOption((int)SettingsEnum.WhoShifts, MultiMenu.neutral, "Who Can Shifter Shift On", new[] { "No Impostors", "Crewmates" });
            ShiftedBecomes = new CustomStringOption((int)SettingsEnum.ShiftedBecomes, MultiMenu.neutral, "Shifted Becomes", new[] { "Shifter", "Crewmate", "Amnesiac" });
            ShifterCrewmate = new CustomToggleOption((int)SettingsEnum.ShifterCrewmate, MultiMenu.neutral, "Shifter Wins With Crew", false);
            ShiftHappensOnMeeting = new CustomToggleOption((int)SettingsEnum.ShiftHappensOnMeeting, MultiMenu.neutral, "Shift happens on a meeting", false);
            ShifterShiftsModifiers = new CustomToggleOption((int)SettingsEnum.ShifterShiftsModifiers, MultiMenu.neutral, "Shifter can shift modifiers", false);

            Amnesiac = new CustomHeaderOption((int)SettingsEnum.Amnesiac, MultiMenu.neutral, "<color=#80B2FFFF><b>Amnesiac</b></color>");
            AmnesiacOn = new CustomNumberOption((int)SettingsEnum.AmnesiacOn, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>", 0f, 0f, 100f, 10f, PercentFormat);
            RememberArrows = new CustomToggleOption((int)SettingsEnum.RememberArrows, MultiMenu.neutral, "Amnesiac Gets Arrows Pointing To Dead Bodies", false);
            RememberArrowDelay = new CustomNumberOption((int)SettingsEnum.RememberArrowDelay, MultiMenu.neutral, "Time After Death Arrow Appears", 5f, 0f, 15f, 1f, CooldownFormat);

            TheGlitch = new CustomHeaderOption((int)SettingsEnum.TheGlitch, MultiMenu.neutral, "<color=#00FF00FF><b>The Glitch</b></color>");
            GlitchOn = new CustomNumberOption((int)SettingsEnum.GlitchOn, MultiMenu.neutral, "<color=#00FF00FF>The Glitch</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MimicCooldownOption = new CustomNumberOption((int)SettingsEnum.MimicCooldownOption, MultiMenu.neutral, "Mimic Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption((int)SettingsEnum.MimicDurationOption, MultiMenu.neutral, "Mimic Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption((int)SettingsEnum.HackCooldownOption, MultiMenu.neutral, "Hack Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption((int)SettingsEnum.HackDurationOption, MultiMenu.neutral, "Hack Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption = new CustomNumberOption((int)SettingsEnum.GlitchKillCooldownOption, MultiMenu.neutral, "Glitch Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption = new CustomStringOption((int)SettingsEnum.GlitchHackDistanceOption, MultiMenu.neutral, "Glitch Hack Distance", new[] { "Short", "Normal", "Long" });
            GlitchVent = new CustomToggleOption((int)SettingsEnum.GlitchVent, MultiMenu.neutral, "Glitch Can Vent", false);

            Arsonist = new CustomHeaderOption((int)SettingsEnum.Arsonist, MultiMenu.neutral, "<color=#FF4D00FF><b>Arsonist</b></color>");
            ArsonistOn = new CustomNumberOption((int)SettingsEnum.ArsonistOn, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DouseCooldown = new CustomNumberOption((int)SettingsEnum.DouseCooldown, MultiMenu.neutral, "Douse Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused = new CustomNumberOption((int)SettingsEnum.MaxDoused, MultiMenu.neutral, "Maximum Alive Players Doused", 5, 1, 15, 1);
            ArsoImpVision = new CustomToggleOption((int)SettingsEnum.ArsoImpVision, MultiMenu.neutral, "Arsonist Has Impostor Vision", false);
            IgniteCdRemoved = new CustomToggleOption((int)SettingsEnum.IgniteCdRemoved, MultiMenu.neutral, "Ignite Cooldown Removed When Arsonist Is Last Killer", false);

            Plaguebearer = new CustomHeaderOption((int)SettingsEnum.Plaguebearer, MultiMenu.neutral, "<color=#E6FFB3FF><b>Plaguebearer</b></color>");
            PlaguebearerOn = new CustomNumberOption((int)SettingsEnum.PlaguebearerOn, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            InfectCooldown = new CustomNumberOption((int)SettingsEnum.InfectCooldown, MultiMenu.neutral, "Infect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown = new CustomNumberOption((int)SettingsEnum.PestKillCooldown, MultiMenu.neutral, "Pestilence Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent = new CustomToggleOption((int)SettingsEnum.PestVent, MultiMenu.neutral, "Pestilence Can Vent", false);

            Speedrunner = new CustomHeaderOption((int)SettingsEnum.Speedrunner, MultiMenu.neutral, "<color=#F7F1DCFF><b>Speedrunner</b></color>");
            SpeedrunnerOn = new CustomNumberOption((int)SettingsEnum.SpeedrunnerOn, MultiMenu.neutral, "<color=#F7F1DCFF>Speedrunner</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SpeedrunnerTasksRemaining = new CustomNumberOption((int)SettingsEnum.SpeedrunnerTasksRemaining, MultiMenu.neutral, "Tasks Remaining When Revealed", 2, 1, 5, 1);
            SpeedrunnerCommonTask = new CustomNumberOption((int)SettingsEnum.SpeedrunnerCommonTask, MultiMenu.neutral, "Common Tasks", 2, 1, 10, 1);
            SpeedrunnerShortTask = new CustomNumberOption((int)SettingsEnum.SpeedrunnerShortTask, MultiMenu.neutral, "Short Tasks", 3, 1, 10, 1);
            SpeedrunnerLongTask = new CustomNumberOption((int)SettingsEnum.SpeedrunnerLongTask, MultiMenu.neutral, "Long Tasks", 2, 1, 10, 1);

            Juggernaut = new CustomHeaderOption((int)SettingsEnum.Juggernaut, MultiMenu.neutral, "<color=#8C004DFF><b>Juggernaut</b></color>");
            JuggernautOn = new CustomNumberOption((int)SettingsEnum.JuggernautOn, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>", 0f, 0f, 100f, 10f, PercentFormat);
            JuggKillCooldown = new CustomNumberOption((int)SettingsEnum.JuggKillCooldown, MultiMenu.neutral, "Juggernaut Initial Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ReducedKCdPerKill = new CustomNumberOption((int)SettingsEnum.ReducedKCdPerKill, MultiMenu.neutral, "Reduced Kill Cooldown Per Kill", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            JuggVent = new CustomToggleOption((int)SettingsEnum.JuggVent, MultiMenu.neutral, "Juggernaut Can Vent", false);

            Jackal = new CustomHeaderOption((int)SettingsEnum.Jackal, MultiMenu.neutral, "<color=#387becFF><b>Jackal</b></color>");
            JackalOn = new CustomNumberOption((int)SettingsEnum.JackalOn, MultiMenu.neutral, "<color=#387becFF>Jackal</color>", 0f, 0f, 100f, 10f, PercentFormat);
            BiteCooldown = new CustomNumberOption((int)SettingsEnum.BiteCooldown, MultiMenu.neutral, "Jackal Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            LightCooldown = new CustomNumberOption((int)SettingsEnum.LightCooldown, MultiMenu.neutral, "Light Sabotage Cooldown", 35f, 10f, 60f, 5f, CooldownFormat);
            VampImpVision = new CustomToggleOption((int)SettingsEnum.VampImpVision, MultiMenu.neutral, "Jackal and Sidekick Have Impostor Vision", false);
            VampVent = new CustomToggleOption((int)SettingsEnum.VampVent, MultiMenu.neutral, "Jackal and Sidekick Can Vent", false);
            NewVampCanAssassin = new CustomToggleOption((int)SettingsEnum.NewVampCanAssassin, MultiMenu.neutral, "Sidekick Can Assassinate", false);
            MaxVampiresPerGame = new CustomNumberOption((int)SettingsEnum.MaxVampiresPerGame, MultiMenu.neutral, "Maximum Jackal-team members Per Game", 2, 2, 5, 1);
            CanBiteNeutralBenign = new CustomToggleOption((int)SettingsEnum.CanBiteNeutralBenign, MultiMenu.neutral, "Can Convert Neutral Benign Roles", false);
            CanBiteNeutralEvil = new CustomToggleOption((int)SettingsEnum.CanBiteNeutralEvil, MultiMenu.neutral, "Can Convert Neutral Evil Roles", false);
            CanBiteImpostors = new CustomToggleOption((int)SettingsEnum.CanBiteImpostors, MultiMenu.neutral, "Can Convert Impostors", false);
            
            Werewolf = new CustomHeaderOption((int)SettingsEnum.Werewolf, MultiMenu.neutral, "<color=#A86629FF><b>Werewolf</b></color>");
            WerewolfOn = new CustomNumberOption((int)SettingsEnum.WerewolfOn, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>", 0f, 0f, 100f, 10f, PercentFormat);
            RampageCooldown = new CustomNumberOption((int)SettingsEnum.RampageCooldown, MultiMenu.neutral, "Rampage Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration = new CustomNumberOption((int)SettingsEnum.RampageDuration, MultiMenu.neutral, "Rampage Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown = new CustomNumberOption((int)SettingsEnum.RampageKillCooldown, MultiMenu.neutral, "Rampage Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent = new CustomToggleOption((int)SettingsEnum.WerewolfVent, MultiMenu.neutral, "Werewolf Can Vent When Rampaged", false);

            Foreteller = new CustomHeaderOption((int)SettingsEnum.Foreteller, MultiMenu.neutral, "<color=#00FF80FF><b>Foreteller</b></color>");
            ForetellerOn = new CustomNumberOption((int)SettingsEnum.ForetellerOn, MultiMenu.neutral, "<color=#00FF80FF>Foreteller</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ForetellerObserveCooldown = new CustomNumberOption((int)SettingsEnum.ForetellerObserveCooldown, MultiMenu.neutral, "Observe Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ForetellerGuessNeutralBenign = new CustomToggleOption((int)SettingsEnum.ForetellerGuessNeutralBenign, MultiMenu.neutral, "Foreteller Can Guess Neutral Benign Roles", false);
            ForetellerGuessNeutralEvil = new CustomToggleOption((int)SettingsEnum.ForetellerGuessNeutralEvil, MultiMenu.neutral, "Foreteller Can Guess Neutral Evil Roles", false);
            ForetellerGuessNeutralKilling = new CustomToggleOption((int)SettingsEnum.ForetellerGuessNeutralKilling, MultiMenu.neutral, "Foreteller Can Guess Neutral Killing Roles", false);
            ForetellerGuessImpostors = new CustomToggleOption((int)SettingsEnum.ForetellerGuessImpostors, MultiMenu.neutral, "Foreteller Can Guess Impostor Roles", false);
            ForetellerAfterVoting = new CustomToggleOption((int)SettingsEnum.ForetellerAfterVoting, MultiMenu.neutral, "Foreteller Can Guess After Voting", false);
            ForetellerGuessesToWin = new CustomNumberOption((int)SettingsEnum.ForetellerGuessesToWin, MultiMenu.neutral, "Number Of Foreteller Kills To Win", 3, 1, 5, 1);
            ForetellerCantObserve = new CustomToggleOption((int)SettingsEnum.ForetellerCantObserve, MultiMenu.neutral, "(Experienced) Foreteller can't observe", false);

            Doomsayer = new CustomHeaderOption((int)SettingsEnum.Doomsayer, MultiMenu.neutral, "<color=#00FF80FF><b>Doomsayer</b></color>");
            DoomsayerOn = new CustomNumberOption((int)SettingsEnum.DoomsayerOn, MultiMenu.neutral, "<color=#00FF80FF>Doomsayer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ObserveCooldown = new CustomNumberOption((int)SettingsEnum.ObserveCooldown, MultiMenu.neutral, "Observe Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DoomsayerGuessNeutralBenign = new CustomToggleOption((int)SettingsEnum.DoomsayerGuessNeutralBenign, MultiMenu.neutral, "Doomsayer Can Guess Neutral Benign Roles", false);
            DoomsayerGuessNeutralEvil = new CustomToggleOption((int)SettingsEnum.DoomsayerGuessNeutralEvil, MultiMenu.neutral, "Doomsayer Can Guess Neutral Evil Roles", false);
            DoomsayerGuessNeutralKilling = new CustomToggleOption((int)SettingsEnum.DoomsayerGuessNeutralKilling, MultiMenu.neutral, "Doomsayer Can Guess Neutral Killing Roles", false);
            DoomsayerGuessImpostors = new CustomToggleOption((int)SettingsEnum.DoomsayerGuessImpostors, MultiMenu.neutral, "Doomsayer Can Guess Impostor Roles", false);
            DoomsayerCantObserve = new CustomToggleOption((int)SettingsEnum.DoomsayerCantObserve, MultiMenu.neutral, "Doomsayer Can't Observe", false);
            
            SoulCollector = new CustomHeaderOption((int)SettingsEnum.SoulCollector, MultiMenu.neutral, "<color=#99FFCCFF><b>Soul Collector</b></color>");
            SoulCollectorOn = new CustomNumberOption((int)SettingsEnum.SoulCollectorOn, MultiMenu.neutral, "<color=#99FFCCFF>Soul Collector</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ReapCooldown = new CustomNumberOption((int)SettingsEnum.ReapCooldown, MultiMenu.neutral, "Reap Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PassiveSoulCollection = new CustomToggleOption((int)SettingsEnum.PassiveSoulCollection, MultiMenu.neutral, "Passively Collect A Soul Each Round", true);
            SoulsToWin = new CustomNumberOption((int)SettingsEnum.SoulsToWin, MultiMenu.neutral, "Amount Of Souls Required To Win", 5, 1, 15, 1);

            Phantom = new CustomHeaderOption((int)SettingsEnum.Phantom, MultiMenu.neutral, "<color=#662962FF><b>Phantom</b></color>");
            PhantomOn = new CustomNumberOption((int)SettingsEnum.PhantomOn, MultiMenu.neutral, "<color=#662962FF>Phantom</color>", 0f, 0f, 100f, 10f, PercentFormat);
            PhantomTasksRemaining = new CustomNumberOption((int)SettingsEnum.PhantomTasksRemaining, MultiMenu.neutral, "Tasks Remaining When Phantom Can Be Clicked", 5, 1, 15, 1);
            PhantomSpook = new CustomToggleOption((int)SettingsEnum.PhantomSpook, MultiMenu.neutral, "Phantom Spooks Player On Victory", true);
            
    
            //ImpostorConcealingRoles = new CustomHeaderOption((int)SettingsEnum.ImpostorConcealingRoles, MultiMenu.imposter, "Impostor Concealing Roles");
            //ImpostorKillingRoles = new CustomHeaderOption((int)SettingsEnum.ImpostorKillingRoles, MultiMenu.imposter, "Impostor Killing Roles");
            //ImpostorSupportRoles = new CustomHeaderOption((int)SettingsEnum.ImpostorSupportRoles, MultiMenu.imposter, "Impostor Support Roles");

            
            Bomber = new CustomHeaderOption((int)SettingsEnum.Bomber, MultiMenu.imposter, "<color=#FF0000FF><b>Bomber</b></color>");
            BomberOn = new CustomNumberOption((int)SettingsEnum.BomberOn, MultiMenu.imposter, "<color=#FF0000FF>Bomber</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DetonateDelay = new CustomNumberOption((int)SettingsEnum.DetonateDelay, MultiMenu.imposter, "Detonate Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            MaxKillsInDetonation = new CustomNumberOption((int)SettingsEnum.MaxKillsInDetonation, MultiMenu.imposter, "Max Kills In Detonation", 5, 1, 15, 1);
            DetonateRadius = new CustomNumberOption((int)SettingsEnum.DetonateRadius, MultiMenu.imposter, "Detonate Radius", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            BomberVent = new CustomToggleOption((int)SettingsEnum.BomberVent, MultiMenu.imposter, "Bomber Can Vent", false);
            AllImpsSeeBomb = new CustomToggleOption((int)SettingsEnum.AllImpsSeeBomb, MultiMenu.imposter, "All Impostors See Bomb", false);

            Detonator = new CustomHeaderOption((int)SettingsEnum.Detonator, MultiMenu.imposter, "<color=#FF0000FF><b>Detonator</b></color>");
            DetonatorOn = new CustomNumberOption((int)SettingsEnum.DetonatorOn, MultiMenu.imposter, "<color=#FF0000FF>Detonator</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DetonatorPlantCooldown = new CustomNumberOption((int)SettingsEnum.DetonatorPlantCooldown, MultiMenu.imposter, "Plant Cooldown", 30f, 1f, 120f, 1f, CooldownFormat);
            DetonatorDetonateCooldown = new CustomNumberOption((int)SettingsEnum.DetonatorDetonateCooldown, MultiMenu.imposter, "Detonate Cooldown", 10f, 1f, 120f, 1f, CooldownFormat);
            DetonatorMaxKillsInDetonation = new CustomNumberOption((int)SettingsEnum.DetonatorMaxKillsInDetonation, MultiMenu.imposter, "Max Kills In Detonation", 5, 1, 15, 1);
            DetonatorRadius = new CustomNumberOption((int)SettingsEnum.DetonatorRadius, MultiMenu.imposter, "Detonate Radius", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            
            Grenadier = new CustomHeaderOption((int)SettingsEnum.Grenadier, MultiMenu.imposter, "<color=#FF0000FF><b>Grenadier</b></color>");
            GrenadierOn = new CustomNumberOption((int)SettingsEnum.GrenadierOn, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>", 0f, 0f, 100f, 10f, PercentFormat);
            GrenadeCooldown = new CustomNumberOption((int)SettingsEnum.GrenadeCooldown, MultiMenu.imposter, "Flash Grenade Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration = new CustomNumberOption((int)SettingsEnum.GrenadeDuration, MultiMenu.imposter, "Flash Grenade Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius = new CustomNumberOption((int)SettingsEnum.FlashRadius, MultiMenu.imposter, "Flash Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators = new CustomToggleOption((int)SettingsEnum.GrenadierIndicators, MultiMenu.imposter, "Indicate Flashed Crewmates", false);
            GrenadierVent = new CustomToggleOption((int)SettingsEnum.GrenadierVent, MultiMenu.imposter, "Grenadier Can Vent", false);
            
            Janitor = new CustomHeaderOption((int)SettingsEnum.Janitor, MultiMenu.imposter, "<color=#FF0000FF><b>Janitor</b></color>");
            JanitorOn = new CustomNumberOption((int)SettingsEnum.JanitorOn, MultiMenu.imposter, "<color=#FF0000FF>Janitor</color>", 0f, 0f, 100f, 10f, PercentFormat);

            Disorienter = new CustomHeaderOption((int)SettingsEnum.Disorienter, MultiMenu.imposter, "<color=#FF0000FF><b>Disorienter</b></color>");
            DisorienterOn = new CustomNumberOption((int)SettingsEnum.DisorienterOn, MultiMenu.imposter, "<color=#FF0000FF>Disorienter</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DisorientCooldown = new CustomNumberOption((int)SettingsEnum.DisorientCooldown, MultiMenu.imposter, "Initial Disorient Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            DisorientTime = new CustomNumberOption((int)SettingsEnum.DisorientTime, MultiMenu.imposter, "Time Of Disorient", 30f, 10f, 60f, 1f, CooldownFormat);

            Blackmailer = new CustomHeaderOption((int)SettingsEnum.Blackmailer, MultiMenu.imposter, "<color=#FF0000FF><b>Blackmailer<b></color>");
            BlackmailerOn = new CustomNumberOption((int)SettingsEnum.BlackmailerOn, MultiMenu.imposter, "<color=#FF0000FF>Blackmailer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            BlackmailCooldown = new CustomNumberOption((int)SettingsEnum.BlackmailCooldown, MultiMenu.imposter, "Initial Blackmail Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            BlackmailInvisible = new CustomToggleOption((int)SettingsEnum.BlackmailInvisible, MultiMenu.imposter, "Only Target Sees Blackmail", false);
            LatestNonVote = new CustomNumberOption((int)SettingsEnum.LatestNonVote, MultiMenu.imposter, "Maximum People Alive Where Blackmailed Can Vote", 5, 1, 15, 1);

            Morphling = new CustomHeaderOption((int)SettingsEnum.Morphling, MultiMenu.imposter, "<color=#FF0000FF><b>Morphling</b></color>");
            MorphlingOn = new CustomNumberOption((int)SettingsEnum.MorphlingOn, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MorphlingCooldown = new CustomNumberOption((int)SettingsEnum.MorphlingCooldown, MultiMenu.imposter, "Morphling Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration = new CustomNumberOption((int)SettingsEnum.MorphlingDuration, MultiMenu.imposter, "Morphling Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent = new CustomToggleOption((int)SettingsEnum.MorphlingVent, MultiMenu.imposter, "Morphling Can Vent", false);
            
            Camouflager = new CustomHeaderOption((int)SettingsEnum.Camouflager, MultiMenu.imposter, "<color=#FF0000FF><b>Camouflager</b></color>");
            CamouflagerOn = new CustomNumberOption((int)SettingsEnum.CamouflagerOn, MultiMenu.imposter, "<color=#FF0000FF>Camouflager</color>", 0f, 0f, 100f, 10f, PercentFormat);
            CamouflagerCooldown = new CustomNumberOption((int)SettingsEnum.CamouflagerCooldown, MultiMenu.imposter, "Camouflager Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            CamouflagerDuration = new CustomNumberOption((int)SettingsEnum.CamouflagerDuration, MultiMenu.imposter, "Camouflager Duration", 10f, 5f, 15f, 1f, CooldownFormat);

            Miner = new CustomHeaderOption((int)SettingsEnum.Miner, MultiMenu.imposter, "<color=#FF0000FF><b>Miner</b></color>");
            MinerOn = new CustomNumberOption((int)SettingsEnum.MinerOn, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MineCooldown = new CustomNumberOption((int)SettingsEnum.MineCooldown, MultiMenu.imposter, "Mine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Escapist = new CustomHeaderOption((int)SettingsEnum.Escapist, MultiMenu.imposter, "<color=#FF0000FF><b>Escapist</b></color>");
            EscapistOn = new CustomNumberOption((int)SettingsEnum.EscapistOn, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>", 0f, 0f, 100f, 10f, PercentFormat);
            EscapeCooldown = new CustomNumberOption((int)SettingsEnum.EscapeCooldown, MultiMenu.imposter, "Recall Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent = new CustomToggleOption((int)SettingsEnum.EscapistVent, MultiMenu.imposter, "Escapist Can Vent", false);

            Hypnotist = new CustomHeaderOption((int)SettingsEnum.Hypnotist, MultiMenu.imposter, "<color=#FF0000FF><b>Hypnotist</b></color>");
            HypnotistOn = new CustomNumberOption((int)SettingsEnum.HypnotistOn, MultiMenu.imposter, "<color=#FF0000FF>Hypnotist</color>", 0f, 0f, 100f, 10f, PercentFormat);
            HypnotiseCooldown = new CustomNumberOption((int)SettingsEnum.HypnotiseCooldown, MultiMenu.imposter, "Hypnotize Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Poisoner = new CustomHeaderOption((int)SettingsEnum.Poisoner, MultiMenu.imposter, "<color=#FF0000FF><b>Poisoner</b></color>");
            PoisonerOn = new CustomNumberOption((int)SettingsEnum.PoisonerOn, MultiMenu.imposter, "<color=#FF0000FF>Poisoner</color>", 0f, 0f, 100f, 10f, PercentFormat);
            PoisonCooldown = new CustomNumberOption((int)SettingsEnum.PoisonCooldown, MultiMenu.imposter, "Poison Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PoisonDuration = new CustomNumberOption((int)SettingsEnum.PoisonDuration, MultiMenu.imposter, "Poison Kill Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            PoisonerCanKill = new CustomToggleOption((int)SettingsEnum.PoisonerCanKill, MultiMenu.imposter, "Poisoner Has Kill Button", true);
            PoisonerVent = new CustomToggleOption((int)SettingsEnum.PoisonerVent, MultiMenu.imposter, "Poisoner Can Vent", false);
            
            Swooper = new CustomHeaderOption((int)SettingsEnum.Swooper, MultiMenu.imposter, "<color=#FF0000FF><b>Swooper</b></color>");
            SwooperOn = new CustomNumberOption((int)SettingsEnum.SwooperOn, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SwoopCooldown = new CustomNumberOption((int)SettingsEnum.SwoopCooldown, MultiMenu.imposter, "Swoop Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SwoopDuration = new CustomNumberOption((int)SettingsEnum.SwoopDuration, MultiMenu.imposter, "Swoop Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SwooperVent = new CustomToggleOption((int)SettingsEnum.SwooperVent, MultiMenu.imposter, "Swooper Can Vent", false);

            Scavenger = new CustomHeaderOption((int)SettingsEnum.Scavenger, MultiMenu.imposter, "<color=#FF0000FF><b>Scavenger</b></color>");
            ScavengerOn = new CustomNumberOption((int)SettingsEnum.ScavengerOn, MultiMenu.imposter, "<color=#FF0000FF>Scavenger</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ScavengeDuration = new CustomNumberOption((int)SettingsEnum.ScavengeDuration, MultiMenu.imposter, "Scavenge Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ScavengeIncreaseDuration = new CustomNumberOption((int)SettingsEnum.ScavengeIncreaseDuration, MultiMenu.imposter, "Scavenge Duration Increase Per Kill", 10f, 5f, 15f, 0.5f, CooldownFormat);
            ScavengeCorrectKillCooldown = new CustomNumberOption((int)SettingsEnum.ScavengeCorrectKillCooldown, MultiMenu.imposter, "Scavenge Kill Cooldown On Correct Kill", 10f, 5f, 15f, 0.5f, CooldownFormat);
            ScavengeIncorrectKillCooldown = new CustomNumberOption((int)SettingsEnum.ScavengeIncorrectKillCooldown, MultiMenu.imposter, "Kill Cooldown Multiplier On Incorrect Kill", 3f, 1.25f, 5f, 0.25f, MultiplierFormat);

            Traitor = new CustomHeaderOption((int)SettingsEnum.Traitor, MultiMenu.imposter, "<color=#FF0000FF><b>Traitor</b></color>");
            TraitorOn = new CustomNumberOption((int)SettingsEnum.TraitorOn, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>", 0f, 0f, 100f, 10f, PercentFormat);
            LatestSpawn = new CustomNumberOption((int)SettingsEnum.LatestSpawn, MultiMenu.imposter, "Minimum People Alive When Traitor Can Spawn", 5, 3, 15, 1);
            NeutralKillingStopsTraitor = new CustomToggleOption((int)SettingsEnum.NeutralKillingStopsTraitor, MultiMenu.imposter, "Traitor Won't Spawn If Any Neutral Killing Is Alive", false);

            Undertaker = new CustomHeaderOption((int)SettingsEnum.Undertaker, MultiMenu.imposter, "<color=#FF0000FF>Undertaker </color>");
            UndertakerOn = new CustomNumberOption((int)SettingsEnum.UndertakerOn, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DragCooldown = new CustomNumberOption((int)SettingsEnum.DragCooldown, MultiMenu.imposter, "Drag Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerDragSpeed = new CustomNumberOption((int)SettingsEnum.UndertakerDragSpeed, MultiMenu.imposter, "Undertaker Drag Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);
            UndertakerVent = new CustomToggleOption((int)SettingsEnum.UndertakerVent, MultiMenu.imposter, "Undertaker Can Vent", false);
            UndertakerVentWithBody = new CustomToggleOption((int)SettingsEnum.UndertakerVentWithBody, MultiMenu.imposter, "Undertaker Can Vent While Dragging", false);

            Venerer = new CustomHeaderOption((int)SettingsEnum.Venerer, MultiMenu.imposter, "<color=#FF0000FF>Venerer</b></color>");
            VenererOn = new CustomNumberOption((int)SettingsEnum.VenererOn, MultiMenu.imposter, "<color=#FF0000FF>Venerer</color>", 0f, 0f, 100f, 10f, PercentFormat);
            AbilityCooldown = new CustomNumberOption((int)SettingsEnum.AbilityCooldown, MultiMenu.imposter, "Ability Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AbilityDuration = new CustomNumberOption((int)SettingsEnum.AbilityDuration, MultiMenu.imposter, "Ability Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SprintSpeed = new CustomNumberOption((int)SettingsEnum.SprintSpeed, MultiMenu.imposter, "Sprint Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);
            FreezeSpeed = new CustomNumberOption((int)SettingsEnum.FreezeSpeed, MultiMenu.imposter, "Freeze Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Warlock = new CustomHeaderOption((int)SettingsEnum.Warlock, MultiMenu.imposter, "<color=#FF0000FF><b>Warlock</b></color>");
            WarlockOn = new CustomNumberOption((int)SettingsEnum.WarlockOn, MultiMenu.imposter, "<color=#FF0000FF>Warlock</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ChargeUpDuration = new CustomNumberOption((int)SettingsEnum.ChargeUpDuration, MultiMenu.imposter, "Time It Takes To Fully Charge", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ChargeUseDuration = new CustomNumberOption((int)SettingsEnum.ChargeUseDuration, MultiMenu.imposter, "Time It Takes To Use Full Charge", 1f, 0.05f, 5f, 0.05f, CooldownFormat);

            CrewmateModifiers = new CustomHeaderOption((int)SettingsEnum.CrewmateModifiers, MultiMenu.modifiers, "Crewmate Modifiers");
            AftermathOn = new CustomNumberOption((int)SettingsEnum.AftermathOn, MultiMenu.modifiers, "<color=#A6FFA6FF>Aftermath</color>", 0f, 0f, 100f, 10f, PercentFormat);
            BaitOn = new CustomNumberOption((int)SettingsEnum.BaitOn, MultiMenu.modifiers, "<color=#33B3B3FF>Bait</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DiseasedOn = new CustomNumberOption((int)SettingsEnum.DiseasedOn, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>", 0f, 0f, 100f, 10f, PercentFormat);
            FrostyOn = new CustomNumberOption((int)SettingsEnum.FrostyOn, MultiMenu.modifiers, "<color=#99FFFFFF>Frosty</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MultitaskerOn = new CustomNumberOption((int)SettingsEnum.MultitaskerOn, MultiMenu.modifiers, "<color=#FF804DFF>Multitasker</color>", 0f, 0f, 100f, 10f, PercentFormat);
            TorchOn = new CustomNumberOption((int)SettingsEnum.TorchOn, MultiMenu.modifiers, "<color=#FFFF99FF>Torch</color>", 0f, 0f, 100f, 10f, PercentFormat);

            GlobalModifiers = new CustomHeaderOption((int)SettingsEnum.GlobalModifiers, MultiMenu.modifiers, "Global Modifiers");
            ButtonBarryOn = new CustomNumberOption((int)SettingsEnum.ButtonBarryOn, MultiMenu.modifiers, "<color=#E600FFFF>Button Barry</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DrunkOn = new CustomNumberOption((int)SettingsEnum.DrunkOn, MultiMenu.modifiers, "<color=#758000FF>Drunk</color>", 0f, 0f, 100f, 10f, PercentFormat);
            FlashOn = new CustomNumberOption((int)SettingsEnum.FlashOn, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>", 0f, 0f, 100f, 10f, PercentFormat);
            GiantOn = new CustomNumberOption((int)SettingsEnum.GiantOn, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>", 0f, 0f, 100f, 10f, PercentFormat);
            LoversOn = new CustomNumberOption((int)SettingsEnum.LoversOn, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>", 0f, 0f, 100f, 10f, PercentFormat);
            MiniOn = new CustomNumberOption((int)SettingsEnum.MiniOn, MultiMenu.modifiers, "<color=#CCFFE6FF>Mini</color>", 0f, 0f, 100f, 10f, PercentFormat);
            RadarOn = new CustomNumberOption((int)SettingsEnum.RadarOn, MultiMenu.modifiers, "<color=#FF0080FF>Radar</color>", 0f, 0f, 100f, 10f, PercentFormat);
            ShyOn = new CustomNumberOption((int)SettingsEnum.ShyOn, MultiMenu.modifiers, "<color=#FFB3CCFF>Shy</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SixthSenseOn = new CustomNumberOption((int)SettingsEnum.SixthSenseOn, MultiMenu.modifiers, "<color=#D9FF8CFF>Sixth Sense</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SleuthOn = new CustomNumberOption((int)SettingsEnum.SleuthOn, MultiMenu.modifiers, "<color=#803333FF>Sleuth</color>", 0f, 0f, 100f, 10f, PercentFormat);
            TiebreakerOn = new CustomNumberOption((int)SettingsEnum.TiebreakerOn, MultiMenu.modifiers, "<color=#99E699FF>Tiebreaker</color>", 0f, 0f, 100f, 10f, PercentFormat);

            ImpostorModifiers = new CustomHeaderOption((int)SettingsEnum.ImpostorModifiers, MultiMenu.modifiers, "Impostor Modifiers");
            DisperserOn = new CustomNumberOption((int)SettingsEnum.DisperserOn, MultiMenu.modifiers, "<color=#FF0000FF>Disperser</color>", 0f, 0f, 100f, 10f, PercentFormat);
            DoubleShotOn = new CustomNumberOption((int)SettingsEnum.DoubleShotOn, MultiMenu.modifiers, "<color=#FF0000FF>Double Shot</color>", 0f, 0f, 100f, 10f, PercentFormat);
            SaboteurOn = new CustomNumberOption((int)SettingsEnum.SaboteurOn, MultiMenu.modifiers, "<color=#FF0000FF>Saboteur</color>", 0f, 0f, 100f, 10f, PercentFormat);
            UnderdogOn = new CustomNumberOption((int)SettingsEnum.UnderdogOn, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>", 0f, 0f, 100f, 10f, PercentFormat);

            DraftModeHeader = new CustomHeaderOption((int)SettingsEnum.DraftModeHeader, MultiMenu.main, "<color=#AAFF2BFF>DRAFT MODE</color>");
            DraftEnabled = new CustomToggleOption((int)SettingsEnum.DraftEnabled, MultiMenu.main, "Draft Mode Enabled", false);
            RandomButtonEnabled = new CustomToggleOption((int)SettingsEnum.RandomButtonEnabled, MultiMenu.main, "Random Button Enabled", true);
            RandomBasesOffChoices = new CustomToggleOption((int)SettingsEnum.RandomBasesOffChoices, MultiMenu.main, "Random can only pick presented options", false);
            PickTime = new CustomNumberOption((int)SettingsEnum.PickTime, MultiMenu.main, "Pick time per player", 10f, 3f, 20f, 1f);
            ButtonAmount = new CustomNumberOption((int)SettingsEnum.ButtonAmount, MultiMenu.main, "Amount of role button (disabled)", 3, 2, 5, 1);
            
            RoleListSettings = new CustomHeaderOption((int)SettingsEnum.RoleListSettings, MultiMenu.main, "Role List Settings");
            UniqueRoles = new CustomToggleOption((int)SettingsEnum.UniqueRoles, MultiMenu.main, "All Roles Are Unique", true);
            SyzyfowyAmong = new CustomToggleOption((int)SettingsEnum.SyzyfowyAmong, MultiMenu.main, "Totalny Chaos.", false);
            Slot1 = new CustomStringOption((int)SettingsEnum.Slot1, MultiMenu.main, "Slot 1", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot2 = new CustomStringOption((int)SettingsEnum.Slot2, MultiMenu.main, "Slot 2", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot3 = new CustomStringOption((int)SettingsEnum.Slot3, MultiMenu.main, "Slot 3", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot4 = new CustomStringOption((int)SettingsEnum.Slot4, MultiMenu.main, "Slot 4", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot5 = new CustomStringOption((int)SettingsEnum.Slot5, MultiMenu.main, "Slot 5", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot6 = new CustomStringOption((int)SettingsEnum.Slot6, MultiMenu.main, "Slot 6", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot7 = new CustomStringOption((int)SettingsEnum.Slot7, MultiMenu.main, "Slot 7", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot8 = new CustomStringOption((int)SettingsEnum.Slot8, MultiMenu.main, "Slot 8", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot9 = new CustomStringOption((int)SettingsEnum.Slot9, MultiMenu.main, "Slot 9", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot10 = new CustomStringOption((int)SettingsEnum.Slot10, MultiMenu.main, "Slot 10", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot11 = new CustomStringOption((int)SettingsEnum.Slot11, MultiMenu.main, "Slot 11", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot12 = new CustomStringOption((int)SettingsEnum.Slot12, MultiMenu.main, "Slot 12", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot13 = new CustomStringOption((int)SettingsEnum.Slot13, MultiMenu.main, "Slot 13", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);
            Slot14 = new CustomStringOption((int)SettingsEnum.Slot14, MultiMenu.main, "Slot 14", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 15);
            Slot15 = new CustomStringOption((int)SettingsEnum.Slot15, MultiMenu.main, "Slot 15", new[] { "<color=#66FFFFFF>Crew</color> Investigative",
                "<color=#66FFFFFF>Crew</color> Killing", "<color=#66FFFFFF>Crew</color> Protective", "<color=#66FFFFFF>Crew</color> Support",
                "Common <color=#66FFFFFF>Crew</color>", "Random <color=#66FFFFFF>Crew</color>", "<color=#999999FF>Neutral</color> Benign",
                "<color=#999999FF>Neutral</color> Evil", "<color=#999999FF>Neutral</color> Killing", "Common <color=#999999FF>Neutral</color>",
                "Random <color=#999999FF>Neutral</color>", "<color=#FF0000FF>Imp</color> Concealing", "<color=#FF0000FF>Imp</color> Killing",
                "<color=#FF0000FF>Imp</color> Support", "Common <color=#FF0000FF>Imp</color>", "Random <color=#FF0000FF>Imp</color>",
                "Non-<color=#FF0000FF>Imp</color>", "Any" }, 16);

            MapSettings = new CustomHeaderOption((int)SettingsEnum.MapSettings, MultiMenu.main, "Map Settings");
            RandomMapEnabled = new CustomToggleOption((int)SettingsEnum.RandomMapEnabled, MultiMenu.main, "Choose Random Map", false);
            RandomMapSkeld = new CustomNumberOption((int)SettingsEnum.RandomMapSkeld, MultiMenu.main, "Skeld Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption((int)SettingsEnum.RandomMapMira, MultiMenu.main, "Mira Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption((int)SettingsEnum.RandomMapPolus, MultiMenu.main, "Polus Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption((int)SettingsEnum.RandomMapAirship, MultiMenu.main, "Airship Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapFungle = new CustomNumberOption((int)SettingsEnum.RandomMapFungle, MultiMenu.main, "Fungle Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption((int)SettingsEnum.RandomMapSubmerged, MultiMenu.main, "Submerged Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapLevelImpostor = new CustomNumberOption((int)SettingsEnum.RandomMapLevelImpostor, MultiMenu.main, "Level Impostor Chance", 0f, 0f, 100f, 10f, PercentFormat);
            SmallMapHalfVision = new CustomToggleOption((int)SettingsEnum.SmallMapHalfVision, MultiMenu.main, "Half Vision On Skeld/Mira HQ", false);
            SmallMapDecreasedCooldown = new CustomNumberOption((int)SettingsEnum.SmallMapDecreasedCooldown, MultiMenu.main, "Mira HQ Decreased Cooldowns", 0f, 0f, 7.5f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown = new CustomNumberOption((int)SettingsEnum.LargeMapIncreasedCooldown, MultiMenu.main, "Airship/Submerged Increased Cooldowns", 0f, 0f, 7.5f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks = new CustomNumberOption((int)SettingsEnum.SmallMapIncreasedShortTasks, MultiMenu.main, "Skeld/Mira HQ Increased Short Tasks", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks = new CustomNumberOption((int)SettingsEnum.SmallMapIncreasedLongTasks, MultiMenu.main, "Skeld/Mira HQ Increased Long Tasks", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks = new CustomNumberOption((int)SettingsEnum.LargeMapDecreasedShortTasks, MultiMenu.main, "Airship/Submerged Decreased Short Tasks", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks = new CustomNumberOption((int)SettingsEnum.LargeMapDecreasedLongTasks, MultiMenu.main, "Airship/Submerged Decreased Long Tasks", 0, 0, 3, 1);

            BetterPolusSettings = new CustomHeaderOption((int)SettingsEnum.BetterPolusSettings, MultiMenu.main, "Better Polus Settings");
            VentImprovements = new CustomToggleOption((int)SettingsEnum.VentImprovements, MultiMenu.main, "Better Polus Vent Layout", false);
            VitalsLab = new CustomToggleOption((int)SettingsEnum.VitalsLab, MultiMenu.main, "Vitals Moved To Lab", false);
            ColdTempDeathValley = new CustomToggleOption((int)SettingsEnum.ColdTempDeathValley, MultiMenu.main, "Cold Temp Moved To Death Valley", false);
            WifiChartCourseSwap = new CustomToggleOption((int)SettingsEnum.WifiChartCourseSwap, MultiMenu.main, "Reboot Wifi And Chart Course Swapped", false);

            CustomGameSettings = new CustomHeaderOption((int)SettingsEnum.CustomGameSettings, MultiMenu.main, "Custom Game Settings");
            CommsDisableTasks = new CustomToggleOption((int)SettingsEnum.CommsDisableTasks, MultiMenu.main, "Sabotaged Comms disable doing tasks", true);
            ColourblindComms = new CustomToggleOption((int)SettingsEnum.ColourblindComms, MultiMenu.main, "Camouflaged Comms", false);
            CamoCommsKillAnyone = new CustomToggleOption((int)SettingsEnum.CamoCommsKillAnyone, MultiMenu.main, "Kill Anyone During Camouflaged Comms", false);
            ImpostorSeeRoles = new CustomToggleOption((int)SettingsEnum.ImpostorSeeRoles, MultiMenu.main, "Impostors Can See The Roles Of Their Team", false);
            DeadSeeRoles = new CustomToggleOption((int)SettingsEnum.DeadSeeRoles, MultiMenu.main, "Dead Can See Everyone's Roles/Votes", false);
            InitialCooldowns = new CustomNumberOption((int)SettingsEnum.InitialCooldowns, MultiMenu.main, "Game Start Cooldowns", 10f, 10f, 30f, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption((int)SettingsEnum.ParallelMedScans, MultiMenu.main, "Parallel Medbay Scans", false);
            SkipButtonDisable = new CustomStringOption((int)SettingsEnum.SkipButtonDisable, MultiMenu.main, "Disable Meeting Skip Button", new[] { "No", "Emergency", "Always" });
            FirstDeathShield = new CustomToggleOption((int)SettingsEnum.FirstDeathShield, MultiMenu.main, "First Death Shield Next Game", false);
            NeutralEvilWinEndsGame = new CustomToggleOption((int)SettingsEnum.NeutralEvilWinEndsGame, MultiMenu.main, "Neutral Evil Win Ends Game", true);
            CrewKillersContinue = new CustomToggleOption((int)SettingsEnum.CrewKillersContinue, MultiMenu.main, "Crew Killers Continue Game", false);

            TaskTrackingSettings = new CustomHeaderOption((int)SettingsEnum.TaskTrackingSettings, MultiMenu.main, "Task Tracking Settings");
            SeeTasksDuringRound = new CustomToggleOption((int)SettingsEnum.SeeTasksDuringRound, MultiMenu.main, "See Tasks During Round", false);
            SeeTasksDuringMeeting = new CustomToggleOption((int)SettingsEnum.SeeTasksDuringMeeting, MultiMenu.main, "See Tasks During Meetings", false);
            SeeTasksWhenDead = new CustomToggleOption((int)SettingsEnum.SeeTasksWhenDead, MultiMenu.main, "See Tasks When Dead", true);

            Assassin = new CustomHeaderOption((int)SettingsEnum.Assassin, MultiMenu.imposter, "<color=#FF0000FF>Assassin Ability</color>");
            NumberOfImpostorAssassins = new CustomNumberOption((int)SettingsEnum.NumberOfImpostorAssassins, MultiMenu.imposter, "Number Of Impostor Assassins", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption((int)SettingsEnum.NumberOfNeutralAssassins, MultiMenu.imposter, "Number Of Neutral Assassins", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption((int)SettingsEnum.AmneTurnImpAssassin, MultiMenu.imposter, "Amnesiac Turned Impostor Gets Ability", false);
            AmneTurnNeutAssassin = new CustomToggleOption((int)SettingsEnum.AmneTurnNeutAssassin, MultiMenu.imposter, "Amnesiac Turned Neutral Killing Gets Ability", false);
            TraitorCanAssassin = new CustomToggleOption((int)SettingsEnum.TraitorCanAssassin, MultiMenu.imposter, "Traitor Gets Ability", false);
            AssassinKills = new CustomNumberOption((int)SettingsEnum.AssassinKills, MultiMenu.imposter, "Number Of Assassin Kills", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption((int)SettingsEnum.AssassinMultiKill, MultiMenu.imposter, "Assassin Can Kill More Than Once Per Meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption((int)SettingsEnum.AssassinCrewmateGuess, MultiMenu.imposter, "Assassin Can Guess \"Crewmate\"", false);
            AssassinGuessNeutralBenign = new CustomToggleOption((int)SettingsEnum.AssassinGuessNeutralBenign, MultiMenu.imposter, "Assassin Can Guess Neutral Benign Roles", false);
            AssassinGuessNeutralEvil = new CustomToggleOption((int)SettingsEnum.AssassinGuessNeutralEvil, MultiMenu.imposter, "Assassin Can Guess Neutral Evil Roles", false);
            AssassinGuessNeutralKilling = new CustomToggleOption((int)SettingsEnum.AssassinGuessNeutralKilling, MultiMenu.imposter, "Assassin Can Guess Neutral Killing Roles", false);
            AssassinGuessImpostors = new CustomToggleOption((int)SettingsEnum.AssassinGuessImpostors, MultiMenu.imposter, "Assassin Can Guess Impostor Roles", false);
            AssassinGuessModifiers = new CustomToggleOption((int)SettingsEnum.AssassinGuessModifiers, MultiMenu.imposter, "Assassin Can Guess Crewmate Modifiers", false);
            AssassinGuessLovers = new CustomToggleOption((int)SettingsEnum.AssassinGuessLovers, MultiMenu.imposter, "Assassin Can Guess Lovers", false);


            Bait = new CustomHeaderOption((int)SettingsEnum.Bait, MultiMenu.modifiers, "<color=#33B3B3FF>Bait</color>");
            BaitMinDelay = new CustomNumberOption((int)SettingsEnum.BaitMinDelay, MultiMenu.modifiers, "Minimum Delay for the Bait Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption((int)SettingsEnum.BaitMaxDelay, MultiMenu.modifiers, "Maximum Delay for the Bait Report", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption((int)SettingsEnum.Diseased, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>");
            DiseasedKillMultiplier = new CustomNumberOption((int)SettingsEnum.DiseasedKillMultiplier, MultiMenu.modifiers, "Diseased Kill Multiplier", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Frosty = new CustomHeaderOption((int)SettingsEnum.Frosty, MultiMenu.modifiers, "<color=#99FFFFFF>Frosty</color>");
            ChillDuration = new CustomNumberOption((int)SettingsEnum.ChillDuration, MultiMenu.modifiers, "Chill Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            ChillStartSpeed = new CustomNumberOption((int)SettingsEnum.ChillStartSpeed, MultiMenu.modifiers, "Chill Start Speed", 0.75f, 0.25f, 0.95f, 0.05f, MultiplierFormat);

            Flash = new CustomHeaderOption((int)SettingsEnum.Flash, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>");
            FlashSpeed = new CustomNumberOption((int)SettingsEnum.FlashSpeed, MultiMenu.modifiers, "Flash Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption((int)SettingsEnum.Giant, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>");
            GiantSlow = new CustomNumberOption((int)SettingsEnum.GiantSlow, MultiMenu.modifiers, "Giant Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Lovers = new CustomHeaderOption((int)SettingsEnum.Lovers, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>");
            BothLoversDie = new CustomToggleOption((int)SettingsEnum.BothLoversDie, MultiMenu.modifiers, "Both Lovers Die");
            LovingImpPercent = new CustomNumberOption((int)SettingsEnum.LovingImpPercent, MultiMenu.modifiers, "Loving Impostor Probability", 20f, 0f, 100f, 10f, PercentFormat);
            NeutralLovers = new CustomToggleOption((int)SettingsEnum.NeutralLovers, MultiMenu.modifiers, "Neutral Roles Can Be Lovers");
            ImpLoverKillTeammate = new CustomToggleOption((int)SettingsEnum.ImpLoverKillTeammate, MultiMenu.modifiers, "Impostor Lover Can Kill Teammate", false);

            Shy = new CustomHeaderOption((int)SettingsEnum.Shy, MultiMenu.modifiers, "<color=#FFB3CCFF>Shy</color>");
            InvisDelay = new CustomNumberOption((int)SettingsEnum.InvisDelay, MultiMenu.modifiers, "Transparency Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            TransformInvisDuration = new CustomNumberOption((int)SettingsEnum.TransformInvisDuration, MultiMenu.modifiers, "Turn Transparent Duration", 5f, 1f, 15f, 1f, CooldownFormat);
            FinalTransparency = new CustomNumberOption((int)SettingsEnum.FinalTransparency, MultiMenu.modifiers, "Final Opacity", 20f, 0f, 80f, 10f, PercentFormat);

            Saboteur = new CustomHeaderOption((int)SettingsEnum.Saboteur, MultiMenu.modifiers, "<color=#FF0000FF>Saboteur</color>");
            ReducedSaboCooldown = new CustomNumberOption((int)SettingsEnum.ReducedSaboCooldown, MultiMenu.modifiers, "Reduced Sabotage Bonus", 10f, 5f, 15f, 1f, CooldownFormat);

            Underdog = new CustomHeaderOption((int)SettingsEnum.Underdog, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>");
            UnderdogKillBonus = new CustomNumberOption((int)SettingsEnum.UnderdogKillBonus, MultiMenu.modifiers, "Kill Cooldown Bonus", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption((int)SettingsEnum.UnderdogIncreasedKC, MultiMenu.modifiers, "Increased Kill Cooldown When 2+ Imps", true);
        }
    }
}