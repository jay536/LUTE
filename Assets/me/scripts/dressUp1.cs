using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class dressUp1 : MonoBehaviour
    {
        public GameObject skirt1;
        public GameObject skirt2;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void addskirt1()
        {
            skirt1.SetActive(true);
            skirt2.SetActive(false);
        }

        public void addskirt2()

        {
            skirt2.SetActive(true);
            skirt1.SetActive(false);
        }
    }
}

