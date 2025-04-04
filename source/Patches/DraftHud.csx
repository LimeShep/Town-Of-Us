using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using AmongUs.GameOptions;

namespace TownOfUs.Patches
{
    /*[HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class HudManagerUpdate
    {
        /*public static void Postfix(HudManager __instance)
        {
            DefaultButton = Object.Instantiate(GameStartManager.StartButton, __instance.transform);
        }
    }*/

    

    public class CreateDraftButtons {
        public static PassiveButton StartButtonInstance, PreButton, EpiButton, PostButton, RandomButton;

        [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Start))]
        [HarmonyPrefix]

        public static void CreateButtons(GameStartManager __instance) {

            PreButton = Object.Instantiate(__instance.StartButton, __instance.transform);
            PreButton.name = "DraftModePreButton";
            
            var preButtonLabel = PreButton.buttonText;
            preButtonLabel.gameObject.GetComponent<TextTranslatorTMP>()?.OnDestroy();
            preButtonLabel.text = "MEDIC";
            var preButtonInactiveRenderer = PreButton.inactiveSprites.GetComponent<SpriteRenderer>();
            preButtonInactiveRenderer.color = Colors.Medic;
            var preButtonActiveRenderer = PreButton.activeSprites.GetComponent<SpriteRenderer>();
            preButtonActiveRenderer.color = Colors.Medic;

            var preButtonInactiveShine = PreButton.inactiveSprites.transform.Find("Shine");

            if (preButtonInactiveShine)
                preButtonInactiveShine.gameObject.SetActive(false);


            EpiButton = Object.Instantiate(__instance.StartButton, __instance.transform);
            EpiButton.name = "DraftModeEpiButton";
            
            var epiButtonLabel = EpiButton.buttonText;
            epiButtonLabel.gameObject.GetComponent<TextTranslatorTMP>()?.OnDestroy();
            epiButtonLabel.text = "SHERIFF";
            var epiButtonInactiveRenderer = EpiButton.inactiveSprites.GetComponent<SpriteRenderer>();
            epiButtonInactiveRenderer.color = Colors.Sheriff;
            var epiButtonActiveRenderer = EpiButton.activeSprites.GetComponent<SpriteRenderer>();
            epiButtonActiveRenderer.color = Colors.Sheriff;

            var epiButtonInactiveShine = EpiButton.inactiveSprites.transform.Find("Shine");

            if (epiButtonInactiveShine)
                epiButtonInactiveShine.gameObject.SetActive(false);


            PostButton = Object.Instantiate(__instance.StartButton, __instance.transform);
            PostButton.name = "DraftModePostButton";
            
            var postButtonLabel = PostButton.buttonText;
            postButtonLabel.gameObject.GetComponent<TextTranslatorTMP>()?.OnDestroy();
            postButtonLabel.text = "TIME LORD";
            var postButtonInactiveRenderer = PostButton.inactiveSprites.GetComponent<SpriteRenderer>();
            postButtonInactiveRenderer.color = Colors.TimeLord;
            var postButtonActiveRenderer = PostButton.activeSprites.GetComponent<SpriteRenderer>();
            postButtonActiveRenderer.color = Colors.TimeLord;

            var postButtonInactiveShine = PostButton.inactiveSprites.transform.Find("Shine");

            if (postButtonInactiveShine)
                postButtonInactiveShine.gameObject.SetActive(false);
            
            PreButton.gameObject.transform.localPosition = new Vector3(3f, 3f, PreButton.gameObject.transform.position.z);
            EpiButton.gameObject.transform.localPosition = new Vector3(3f, 2.2f, EpiButton.gameObject.transform.position.z);
            PostButton.gameObject.transform.localPosition = new Vector3(3f, 1.4f, PostButton.gameObject.transform.position.z);

            PreButton.activeTextColor = PreButton.inactiveTextColor = Color.white;
            EpiButton.activeTextColor = EpiButton.inactiveTextColor = Color.white;
            PostButton.activeTextColor = PostButton.inactiveTextColor = Color.white;
        }

        public static void ShowButtons(bool on) {
            PreButton.gameObject.SetActive(on);
            EpiButton.gameObject.SetActive(on);
            PostButton.gameObject.SetActive(on);
        }

        [HarmonyPatch(typeof(GameStartManager), nameof(GameStartManager.Update))]
        [HarmonyPrefix]
        public static void PrefixUpdate(GameStartManager __instance)
        {
            if (__instance == null || !AmongUsClient.Instance.AmHost) return;

            if (CustomGameOptions.DraftEnabled) {
                System.Console.WriteLine("Displaying");
                ShowButtons(true);
            } else ShowButtons(false);
        }
    }
}