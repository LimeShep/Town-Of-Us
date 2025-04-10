using HarmonyLib;
using TownOfUs.Roles;
using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.ImpostorRoles.DetonatorMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformKill
    {
        public static bool Prefix(KillButton __instance)
        {
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Detonator)) return true;
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var role = Role.GetRole<Detonator>(PlayerControl.LocalPlayer);
            var target = role.ClosestPlayer;
            if (__instance == role.PlantButton)
            {
                if (!__instance.isActiveAndEnabled || role.ClosestPlayer == null) return false;
                if (__instance.isCoolingDown) return false;
                if (!__instance.isActiveAndEnabled) return false;
                if (role.BombAttached ? role.PlantTimer(true) != 0 : role.PlantTimer(false) != 0) return false;

                var interact = Utils.Interact(PlayerControl.LocalPlayer, target);
                if (interact[4] == true)
                {
                    if (!role.BombAttached)
                    {
                        role.BombPlayer?.myRend().material.SetFloat("_Outline", 0f);
                        if (role.BombPlayer != null && role.BombPlayer.Data.IsImpostor())
                        {
                            if (role.BombPlayer.GetCustomOutfitType() != CustomPlayerOutfitType.Camouflage &&
                                role.BombPlayer.GetCustomOutfitType() != CustomPlayerOutfitType.Swooper)
                                role.BombPlayer.nameText().color = Patches.Colors.Impostor;
                            else role.BombPlayer.nameText().color = Color.clear;
                        }
                        role.BombPlayer = target;
                        role.Plant(role.BombPlayer);
                        role.BombAttached = true;
                    } else
                    {
                        role.Detonate(role.BombPlayer);
                        role.BombAttached = false;
                        role.BombPlayer = null;
                    }
                    role.LastPlanted = System.DateTime.UtcNow;
                }
                role.PlantButton.SetCoolDown(0.01f, 1f);
                return false;
            }
            return true;
        }
    }
}