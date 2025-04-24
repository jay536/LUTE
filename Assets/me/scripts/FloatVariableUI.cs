using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class FloatVariableUI : MonoBehaviour
    {
        [Tooltip("The text component to display the float variable.")]
        [SerializeField] protected TMPro.TextMeshProUGUI textComponent;

        [VariableProperty(typeof(IntegerVariable))]
        [SerializeField] protected IntegerVariable floatVariable;

        [VariableProperty(typeof(BooleanVariable))]
        [SerializeField] protected BooleanVariable canUnlockItem;

        [VariableProperty(typeof(BooleanVariable))]
        [SerializeField] protected BooleanVariable revealUI;

        [VariableProperty(typeof(FloatVariable))]
        [SerializeField] protected FloatVariable revealTime;

        [SerializeField] protected GameObject gameui;
        [SerializeField] protected CanvasGroup canvasGroup;

        private float fadeTimer = 0f;
        private bool isFadingIn = false;

        private void Update()
        {
            if (textComponent == null || floatVariable == null || canvasGroup == null)
                return;

            // Update display
            int minutes = floatVariable.Value;
            int hours = minutes / 60;
            int mins = minutes % 60;
            textComponent.text = $"{hours:D2}:{mins:D2}";

            if (canUnlockItem.Value == true)
            {
                FadeOut();
            }
            else
            {
                HandleRevealUI();
            }

            UpdateFade();
        }

        private void HandleRevealUI()
        {
            if (revealUI.Value == true)
            {
                isFadingIn = true;
                fadeTimer = 0f;
            }
            else
            {
                isFadingIn = false;
                fadeTimer = 0f;
            }
        }

        private void FadeOut()
        {
            isFadingIn = false;
            fadeTimer = 0f;
        }

        private void UpdateFade()
        {
            float duration = Mathf.Max(0.01f, revealTime.Value); // avoid division by zero
            float targetAlpha = isFadingIn ? 1f : 0f;

            // Smoothly interpolate alpha
            canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, targetAlpha, Time.deltaTime / duration);

            // Enable interaction only when visible enough
            bool visible = canvasGroup.alpha > 0.01f;
            canvasGroup.interactable = visible;
            canvasGroup.blocksRaycasts = visible;
        }
    }
}
