using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class draganddrop1control : MonoBehaviour
    {

        public GameObject image1;
        public GameObject image2;
        public Transform spawnto;
        public GameObject parentObject;

        public GameObject gameui;
        public GameObject screenshotui;
        public GameObject bin;
        public GameObject screenshotcontrol;

        public GameObject game;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            gameui.SetActive(true);
            screenshotui.SetActive(false);
            bin.SetActive(true);
            screenshotcontrol.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
           

        }

       

       public void Spawnimage1()
        {
            GameObject newimage1 = Instantiate(image1, spawnto.position, Quaternion.identity);
            //Instantiate(image1, parentObject.transform);
            newimage1.transform.parent = spawnto.transform;
            
        }
        public void Spawnimage2()
        {
            GameObject newimage2 = Instantiate(image2, spawnto.position, Quaternion.identity);
            newimage2.transform.parent = spawnto.transform;
        }

        public void openscreenshotmenu()
        {
            gameui.SetActive(false);
            screenshotui.SetActive(true);
            bin.SetActive(false);
            screenshotcontrol.SetActive(true);
        }

        public void close()
        {
            game.SetActive(false);
        }
    }
}
