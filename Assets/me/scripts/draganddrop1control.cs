using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class draganddrop1control : MonoBehaviour
    {

        public GameObject image1;
        public GameObject image2;
        public Transform spawnto;

        public GameObject game;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
           

        }

       

       public void Spawnimage1()
        {
            Instantiate(image1, spawnto.position, Quaternion.identity);
        }
        public void Spawnimage2()
        {
            Instantiate(image2, spawnto.position, Quaternion.identity);
        }

        public void close()
        {
            game.SetActive(false);
        }
    }
}
