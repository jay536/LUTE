using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class characterfound : MonoBehaviour
    {

        public GameObject youfoundme;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }


        public void close()
        {
            youfoundme.SetActive(false);
        }
    }
}
