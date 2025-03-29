using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine.UI;

namespace TownOfUs.NeutralRoles.ForetellerMod
{
    [HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Confirm))]
    public class ShowHideButtonsFore
    {
        public static void HideButtonsFore(Foreteller role)
        {
            foreach (var (_, (cycleBack, cycleForward, guess, guessText)) in role.Buttons)
            {
                if (cycleBack == null || cycleForward == null) continue;
                cycleBack.SetActive(false);
                cycleForward.SetActive(false);
                guess.SetActive(false);
                guessText.gameObject.SetActive(false);

                cycleBack.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
                cycleForward.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
                guess.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
            }
        }

        public static void HideSingle(
            Foreteller role,
            byte targetId,
            bool killedSelf
        )
        {
            if (killedSelf) HideButtonsFore(role);
            else HideTarget(role, targetId);
        }
        public static void HideTarget(
            Foreteller role,
            byte targetId
        )
        {

            var (cycleBack, cycleForward, guess, guessText) = role.Buttons[targetId];
            if (cycleBack == null || cycleForward == null) return;
            cycleBack.SetActive(false);
            cycleForward.SetActive(false);
            guess.SetActive(false);
            guessText.gameObject.SetActive(false);

            cycleBack.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
            cycleForward.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
            guess.GetComponent<PassiveButton>().OnClick = new Button.ButtonClickedEvent();
            role.Buttons[targetId] = (null, null, null, null);
            role.Guesses.Remove(targetId);
        }


        public static void Prefix(MeetingHud __instance)
        {
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Foreteller)) return;
            var foreteller = Role.GetRole<Foreteller>(PlayerControl.LocalPlayer);
            if (!CustomGameOptions.ForetellerAfterVoting) HideButtonsFore(foreteller);
        }
    }
}
