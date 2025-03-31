using UnityEngine;
using UnityEngine.UI;

namespace LoGaCulture.LUTE
{
    public class colourchange2 : MonoBehaviour
    {

        public Image colour;
        public Image color2;
        public Image color3;
        public Image color4;

        public Color colour1, colour2, colour3, colour4, colour5, colour6, colour7, colour8;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void white()
        {
            colour.color = colour1;
            color2.color = colour1;
            color3.color = colour1;
            color4.color = colour1;
        }
        public void black()
        {
            colour.color = colour2;
            color2.color = colour2;
            color3.color = colour2;
            color4.color = colour2;
        }
        public void red()
        {
            colour.color = colour3;
            color2.color = colour3;
            color3.color = colour3;
            color4.color = colour3;
        }
        public void orange()
        {
            colour.color = colour4;
            color2.color = colour4;
            color3.color = colour4;
            color4.color = colour4;
        }
        public void yellow()
        {
            colour.color = colour5;
            color2.color = colour5;
            color3.color = colour5;
            color4.color = colour5;
        }
        public void green()
        {
            colour.color = colour6;
            color2.color = colour6;
            color3.color = colour6;
            color4.color = colour6;
        }
        public void blue()
        {
            colour.color = colour7;
            color2.color = colour7;
            color3.color = colour7;
            color4.color = colour7;
        }
        public void purple()
        {
            colour.color = colour8;
            color2.color = colour8;
            color3.color = colour8;
            color4.color = colour8;
        }





    }
}
