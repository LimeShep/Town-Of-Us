using System.Collections.Generic;
using TownOfUs.Extensions;
using UnityEngine;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace TownOfUs.Roles
{
    public class Security : Role
    {
        public int UsesLeft;
        public TextMeshPro UsesText;
        public bool ButtonUsable => UsesLeft > 0;
        public KillButton _camButton;
        public int placedCameras;
        
        public Security(PlayerControl player) : base(player)
        {
            Name = "Security";
            ImpostorText = () => "Analyze the whole map";
            TaskText = () => "Place and view the cams!";
            Color = Patches.Colors.Security;
            RoleType = RoleEnum.Security;
            AddToRoleHistory(RoleType);
            Faction = Faction.Crewmates;
            UsesLeft = CustomGameOptions.CamAmount;
            placedCameras = 0;
        }

        public KillButton CamButton
        {
            get => _camButton;
            set
            {
                _camButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
    }
}