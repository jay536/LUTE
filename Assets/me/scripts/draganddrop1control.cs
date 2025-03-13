using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class draganddrop1control : MonoBehaviour
    {

        public GameObject image1;
        public GameObject image2;
        public GameObject image3;
        public GameObject image4;
        public GameObject image5;
        public GameObject image6;
        public GameObject image7;
        public GameObject image8;
        public GameObject image9;
        public GameObject image10;
        public GameObject image11;
        public GameObject image12;

        public Transform spawnto;
        public GameObject parentObject;

        public GameObject gameui;
        public GameObject screenshotui;
        public GameObject bin;
        public GameObject screenshotcontrol;
        public GameObject luteui;
        public GameObject dialogue;
        public GameObject gameobjects;
        public GameObject screenshotbutton;

        public GameObject game;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            gameui.SetActive(true);
            screenshotui.SetActive(false);
            bin.SetActive(true);
            screenshotcontrol.SetActive(false);

            luteui = GameObject.Find("PopupIcon");

        }

        // Update is called once per frame
        void Update()
        {
           

        }

       

       public void Spawnimage1()
        {
            GameObject newimage1 = Instantiate(image1, spawnto.position, spawnto.rotation);
            //Instantiate(image1, parentObject.transform);
            newimage1.transform.parent = spawnto.transform;
            
        }
        public void Spawnimage2()
        {
            GameObject newimage2 = Instantiate(image2, spawnto.position, spawnto.rotation);
            newimage2.transform.parent = spawnto.transform;
        }

        public void Spawnimage3()
        {
            GameObject newimage3 = Instantiate(image3, spawnto.position, spawnto.rotation);
            newimage3.transform.parent = spawnto.transform;
        }
        public void Spawnimage4()
        {
            GameObject newimage4 = Instantiate(image4, spawnto.position, spawnto.rotation);
            newimage4.transform.parent = spawnto.transform;
        }
        public void Spawnimage5()
        {
            GameObject newimage5 = Instantiate(image5, spawnto.position, spawnto.rotation);
            newimage5.transform.parent = spawnto.transform;
        }
        public void Spawnimage6()
        {
            GameObject newimage6 = Instantiate(image6, spawnto.position, spawnto.rotation);
            newimage6.transform.parent = spawnto.transform;
        }
        public void Spawnimage7()
        {
            GameObject newimage7 = Instantiate(image7, spawnto.position, spawnto.rotation);
            newimage7.transform.parent = spawnto.transform;
        }
        public void Spawnimage8()
        {
            GameObject newimage8 = Instantiate(image8, spawnto.position, spawnto.rotation);
            newimage8.transform.parent = spawnto.transform;
        }
        public void Spawnimage9()
        {
            GameObject newimage9 = Instantiate(image9, spawnto.position, spawnto.rotation);
            newimage9.transform.parent = spawnto.transform;
        }
        public void Spawnimage10()
        {
            GameObject newimage10 = Instantiate(image10, spawnto.position, spawnto.rotation);
            newimage10.transform.parent = spawnto.transform;
        }
        public void Spawnimage11()
        {
            GameObject newimage11 = Instantiate(image11, spawnto.position, spawnto.rotation);
            newimage11.transform.parent = spawnto.transform;
        }
        public void Spawnimage12()
        {
            GameObject newimage12 = Instantiate(image12, spawnto.position, spawnto.rotation);
            newimage12.transform.parent = spawnto.transform;
        }

        public void openscreenshotmenu()
        {
            gameui.SetActive(false);
            screenshotui.SetActive(true);
            bin.SetActive(false);
            screenshotcontrol.SetActive(true);
            luteui.SetActive(false);
            screenshotbutton.SetActive(true);
        }

        public void close()
        {
            game.SetActive(false);
            luteui.SetActive(true);
            dialogue.SetActive(true);
            gameobjects.SetActive(false);
            screenshotbutton.SetActive(false);

           /* gameui.SetActive(true);
            screenshotui.SetActive(false);
            screenshotcontrol.SetActive(false);
            bin.SetActive(true);
            screenshotbutton.SetActive(false);*/
        }

        public void refresh()
        {
            gameui.SetActive(true);
            screenshotui.SetActive(false);
            screenshotcontrol.SetActive(false);
            bin.SetActive(true);
            screenshotbutton.SetActive(false);
            gameobjects.SetActive(true);
        }

    }
}
