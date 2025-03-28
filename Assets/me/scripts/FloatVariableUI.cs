using UnityEngine;

namespace LoGaCulture.LUTE
{
    /// <summary>
    /// A simple helper class that allows for the display of a float variable in the Unity Editor.
    /// In the example we display the float as text but you could easily modify this to display as a slider or other UI element.
    /// </summary>
    public class FloatVariableUI : MonoBehaviour
    {
        [Tooltip("The text component to display the float variable.")]
        [SerializeField] protected TMPro.TextMeshProUGUI textComponent;
        [Tooltip("The float variable to display.")]
        [VariableProperty(typeof(IntegerVariable))]
        [SerializeField] protected IntegerVariable floatVariable;
        [Tooltip("A boolean variable to constrain the showing of UI elements.")]
        [VariableProperty(typeof(BooleanVariable))]
        [SerializeField] protected BooleanVariable showUI;

        [SerializeField] protected GameObject gameui;

        //public float time;

        private void Update()
        {
            if (textComponent != null && floatVariable != null && showUI != null)
            {
                // If this is false (i.e., we are waiting to be able to click) then show the time left
                if (showUI.Value == false)
                {
                    textComponent.enabled = true;
                    gameui.SetActive(true);

                    /* int minutes = floatVariable.Value;
                     int hours = minutes / 60;
                     int mins = minutes % 60;

                     string timeFormat = $"{hours:D2}:{mins:D2}";*/
                }
                else
                {
                    // Once we can click, hide the time left
                    // You could also show something here to inform the player they can now click
                    textComponent.enabled = false;
                    gameui.SetActive(false);
                }

                textComponent.text = floatVariable.Value.ToString();



                /* if (time > 0)
                 {
                     time -= Time.deltaTime;
                 }
                 else if (time < 0)
                 {
                     time = 0;
                 }
                 int minutes = Mathf.FloorToInt(time / 60);
                 int seconds = Mathf.FloorToInt(time % 60);
                 textComponent.text = string.Format("{0:00}:{1:00}", minutes, seconds);

                 time = float.Parse(textComponent.text);
                 //time = float.TryParse(floatVariable);*/
                int minutes = floatVariable.Value;
                int hours = minutes / 60;
                int mins = minutes % 60;

                string timeFormat = $"{hours:D2}:{mins:D2}";
                textComponent.text = timeFormat;
            }
            // If we cannot find the text component or relevant variables then disable it


            else
                textComponent.enabled = false;

            
        }

        /*private void Start()
        {

            {
                time = floatVariable.Value;
            }
        }*/
    }
}
