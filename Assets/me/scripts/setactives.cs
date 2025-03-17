using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class setactives : MonoBehaviour
    {

        public GameObject dressup;
        public GameObject create;
        public GameObject spotthedif;
        public GameObject find;
        public GameObject nogame;

        public CanvasGroup inventory;

        //public GameObject collected;


        //public GameObject character1;
        //public GameObject character2;
        //public GameObject charater3;
       // public GameObject charater4;
        //public float collectedNum;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //collectedNum = 0;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void dressupon()
        {
            dressup.SetActive(true);
            //character1.SetActive(true);
        }

        public void createon()
        {
            create.SetActive(true);
        }

        public void spotthedifon()
        {
            spotthedif.SetActive(true);
        }

        public void findon()
        {
            find.SetActive(true);
        }

       /* public void opencollected()
        {

         collected.SetActive(true);
        }
        public void closecollected()
        {
         collected.SetActive(false);
        }*/

        public void noGame()
        {
            nogame.SetActive(true);
        }
        public void closeNoGame()
        {
            nogame.SetActive(false);
        }

        public void hideinventory()
        {
            inventory.alpha = 0;
        }
        public void showinventory()
        {
            inventory.alpha = 1;
        }
    }
}
