using System.Collections.Generic;
using TownOfUs.Extensions;
using UnityEngine;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace TownOfUs.Roles
{
    public class Conserver : Role
    {
        public int UsesLeft;
        public TextMeshPro UsesText;
        public bool ButtonUsable => UsesLeft > 0;
        public Vent ClosestVent;
        
        public Conserver(PlayerControl player) : base(player)
        {
            Name = "Conserver";
            ImpostorText = () => "Seal vents";
            TaskText = () => "Seal vents";
            Color = Patches.Colors.Conserver;
            RoleType = RoleEnum.Conserver;
            AddToRoleHistory(RoleType);
            Faction = Faction.Crewmates;
            UsesLeft = 1;
        }
    }
}