using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using System.Linq;

namespace TownOfUs.CrewmateRoles.ConserverMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public class PerformKill {
        
        public static bool Prefix(KillButton __instance) {
            if (__instance != DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            var flag = PlayerControl.LocalPlayer.Is(RoleEnum.Conserver);
            if (!flag) return true;
            var role = Role.GetRole<Conserver>(PlayerControl.LocalPlayer);
            if (!PlayerControl.LocalPlayer.CanMove || role.ClosestVent == null) return false;
            if (!__instance.enabled) return false;
            if (!role.ButtonUsable) return false;

            Vent vent = ShipStatus.Instance.AllVents.FirstOrDefault((x) => x != null && x.Id == role.ClosestVent.Id);
            if (vent == null) return false;

            role.UsesLeft--;
            Utils.Rpc(CustomRPC.Seal, role.ClosestVent.Id);
            PowerTools.SpriteAnim animator = vent.GetComponent<PowerTools.SpriteAnim>(); 
                            
            vent.EnterVentAnim = vent.ExitVentAnim = null;
            Sprite newSprite = TownOfUs.VentSealed;
            SpriteRenderer rend = vent.myRend;
                            /*if (Helpers.isFungle()) {
                                newSprite = SecurityGuard.getFungleVentSealedSprite();
                                rend = vent.transform.GetChild(3).GetComponent<SpriteRenderer>();
                                animator = vent.transform.GetChild(3).GetComponent<PowerTools.SpriteAnim>();
                            }*/
            animator?.Stop();
            rend.sprite = newSprite;
                            //if (SubmergedCompatibility.isSubmerged() && vent.Id == 0) vent.myRend.sprite = SecurityGuard.getSubmergedCentralUpperSealedSprite();
                            //if (SubmergedCompatibility.isSubmerged() && vent.Id == 14) vent.myRend.sprite = SecurityGuard.getSubmergedCentralLowerSealedSprite();
            rend.color = new Color(1f, 1f, 1f, 0.5f);
            vent.name = "FutureSealedVent_" + vent.name;
            //sealVent(role.ClosestVent.Id, role);
            return false;
        } 
    }
}