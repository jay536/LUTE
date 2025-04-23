using System.Collections;
using TMPro;
using UnityEngine;

namespace LoGaCulture.LUTE
{
    /// <summary>
    /// Inherited from information panel to be used as a panel that displays a hint relating to various mini-games.
    /// Often called from inventory systems.
    /// </summary>
    public class HintPanel : InformationPanel
    {
        [Tooltip("The main canvas group that is used to fade the panel in and out.")]
        [SerializeField] protected CanvasGroup canvasGroup;
        [Tooltip("The hint text component that is rendered to the screen.")]
        [SerializeField] protected TextMeshProUGUI hintText;
        [Tooltip("The hint button that reveals the location based on the panel.")]
        [SerializeField] protected UnityEngine.UI.Button hintButton;
        [Tooltip("How long to fade the menu in and out for.")]
        [SerializeField] protected float fadeDuration = 0.5f;

        public override void TogglePanel()
        {
            FadePanelCanvas();
        }

        /// <summary>
        /// Sets the information to be displayed on the panel.
        /// </summary>
        /// <param name="text"></param>
        public void SetInformation(string text, LocationVariable location, BasicFlowEngine engine, bool showDialogue, string revealText, Character character = null, float typingSpeed = 30.0f)
        {
            if (hintText == null)
            {
                hintText = GetComponentInChildren<TextMeshProUGUI>();
            }

            if (hintText == null)
            {
                return;
            }
            hintText.text = text;

            if (location == null || engine == null)
            {
                return;
            }

            if (hintButton == null)
            {
                hintButton = GetComponentInChildren<UnityEngine.UI.Button>();
            }

            if (hintButton == null)
            {
                return;
            }

            var mapManager = engine.GetMapManager();

            if (mapManager == null)
            {
                return;
            }

            hintButton.onClick.RemoveAllListeners();
            hintButton.onClick.AddListener(() => { mapManager.ShowLocationMarker(location); TogglePanel(); if (showDialogue) StartHintDialogue(engine, revealText, character, typingSpeed); });
        }

        private void StartHintDialogue(BasicFlowEngine engine, string revealText, Character dialogueCharacter = null, float typingSpeed = 30.0f)
        {
            var dialogueBox = DialogueBox.GetDialogueBox();
            if (dialogueBox == null)
            {
                return;
            }

            dialogueBox.SetActive(true);

            if (dialogueCharacter != null)
            {
                dialogueBox.SetCharacter(dialogueCharacter);
                dialogueBox.SetCharacterImage(dialogueCharacter.Portraits[0]);
            }

            string displayText = "My location has been revealed!";
            if (!string.IsNullOrEmpty(revealText))
            {
                displayText = revealText;
            }

            var activeCustomTags = CustomTag.activeCustomTags;
            for (int i = 0; i < activeCustomTags.Count; i++)
            {
                var ct = activeCustomTags[i];
                displayText = displayText.Replace(ct.TagStartSymbol, ct.ReplaceTagStartWith);
                // If the tag has an end symbol and a replacement for it, we replace it
                if (ct.TagEndSymbol != "" && ct.ReplaceTagEndWith != "")
                {
                    displayText = displayText.Replace(ct.TagEndSymbol, ct.ReplaceTagEndWith);
                }
            }

            string subbedText = engine.SubstituteVariables(displayText);

            dialogueBox.StartDialogue(subbedText, true, true, true, true, true, null, null, typingSpeed, true, null);
        }

        private void FadePanelCanvas()
        {
            if (canvasGroup == null)
            {
                return;
            }


            if (isPanelActive)
            {
                isPanelActive = false;
                canvasGroup.interactable = false;
                canvasGroup.blocksRaycasts = false;
                StartCoroutine(FadeCanvasGroupIEnum(canvasGroup, fadeDuration, 0f));
            }
            else
            {
                isPanelActive = true;
                canvasGroup.interactable = true;
                canvasGroup.blocksRaycasts = true;
                StartCoroutine(FadeCanvasGroupIEnum(canvasGroup, fadeDuration, 1f));
            }
        }

        private IEnumerator FadeCanvasGroupIEnum(CanvasGroup target, float duration, float targetAlpha, bool unscaled = true)
        {
            if (target == null)
            {
                target = canvasGroup;
            }

            if (target == null)
            {
                yield break;
            }

            float currentAlpha = target.alpha;

            float t = 0f;
            while (t < 1.0f)
            {
                if (target == null)
                    yield break;

                float newAlpha = Mathf.SmoothStep(currentAlpha, targetAlpha, t);
                target.alpha = newAlpha;

                if (unscaled)
                {
                    t += Time.unscaledDeltaTime / duration;
                }
                else
                {
                    t += Time.deltaTime / duration;
                }

                yield return null;
            }

            target.alpha = targetAlpha;
        }
    }
}
