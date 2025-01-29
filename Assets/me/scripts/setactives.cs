using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class setactives : MonoBehaviour
    {

        public GameObject dressup;

        public GameObject collected;


        public GameObject character1;
        public GameObject character2;
        public GameObject charater3;
        public GameObject charater4;
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
            character1.SetActive(true);
        }

        public void opencollected()
        {

         collected.SetActive(true);
        }
        public void closecollected()
        {
         collected.SetActive(false);
        }
    }
}
