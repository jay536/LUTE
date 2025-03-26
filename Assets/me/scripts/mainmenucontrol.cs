using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class mainmenucontrol : MonoBehaviour
    {

        public GameObject fullmenu;

        public GameObject menu;

        public GameObject credits;

        public GameObject splash;

        //public GameObject luteui;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            splash.SetActive(true);
            menu.SetActive(false);
            credits.SetActive(false);
           // luteui = GameObject.Find("PopupIcon");

           // luteui.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void start()
        {
            fullmenu.SetActive(false);
           // luteui.SetActive(true);
        }

        public void closesplash()
        {
            splash.SetActive(false);
            menu.SetActive(true);
        }

        public void opencredits()
        {
            credits.SetActive(true);
            menu.SetActive(false);
        }

        public void closecredits()
        {
            credits.SetActive(false);
            menu.SetActive(true);
        }
    }
}
