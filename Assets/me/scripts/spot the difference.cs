using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class spotthedifference : MonoBehaviour
    {

        public GameObject difference1;
        public GameObject difference2;
        public GameObject difference3;

        public GameObject difference11;
        public GameObject difference22;
        public GameObject difference33;

        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

        public float diffound;

        public GameObject gameendui;

        public GameObject game;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (diffound == 3)
            {
                gameendui.SetActive(true);
            }
        
        }

        public void finddifference1()
        {
            difference1.SetActive(true);
            button1.SetActive(false);
            diffound = diffound + 1;
            difference11.SetActive(true);
        }
        public void finddifference2()
        {
            difference2.SetActive(true);
            button2.SetActive(false);
            diffound = diffound + 1;
            difference22.SetActive(true);
        }
        public void finddifference3()
        {
            difference3.SetActive(true);
            button3.SetActive(false);
            diffound = diffound + 1;
            difference33.SetActive(true);
        }

        public void end()
        {
            difference1.SetActive(false);
            difference11.SetActive(false);
            button1.SetActive(true);

            difference2.SetActive(false);
            difference22.SetActive(false);
            button2.SetActive(true);

            difference3.SetActive(false);
            difference3.SetActive(false);
            button3.SetActive(true);

            diffound = 0;

            gameendui.SetActive(false);
            game.SetActive(false);
        }

    }
}
