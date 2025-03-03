using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class uiscreenshotcontrol : MonoBehaviour
    {

        public GameObject ui;

        public bool uion;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            uion = true;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        /*void OnMouseDown()
        {
            if (uion == true)
            {
                ui.SetActive(false);
            }
            if(uion == false)
            {
                ui.SetActive(true);
                //uionoff = true;
            }
        }
        private void OnMouseUp()
        {
            if (uion == true)
            {
                uion = (false);
            }
            else if (uion == false)
            {
                uion = true;
            }
        }*/

        public void hide()
        {
            if (uion == true)
            {
                ui.SetActive(false);
            }
            if (uion == false)
            {
                ui.SetActive(true);
                //uionoff = true;
            }
        }

        public void show()
        {
            if (uion == true)
            {
                uion = (false);
            }
            else if (uion == false)
            {
                uion = true;
            }
        }

    }
}
