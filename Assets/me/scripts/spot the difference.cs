using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class spotthedifference : MonoBehaviour
    {

        public GameObject difference1;
        public GameObject difference2;
        public GameObject difference3;
        public GameObject difference4;
        public GameObject difference5;

        public GameObject difference11;
        public GameObject difference22;
        public GameObject difference33;
        public GameObject difference44;
        public GameObject difference55;

        public GameObject button1;
        public GameObject button2;
        public GameObject button3;
        public GameObject button4;
        public GameObject button5;

        public GameObject button11;
        public GameObject button22;
        public GameObject button33;
        public GameObject button44;
        public GameObject button55;

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
            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
        
        }

        public void finddifference1()
        {
            difference1.SetActive(true);
            button1.SetActive(false);
            button11.SetActive(false);
            
            difference11.SetActive(true);
            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
            else
            {
                diffound = diffound + 1;
            }
        }
        public void finddifference2()
        {
            difference2.SetActive(true);
            button2.SetActive(false);
            button22.SetActive(false);
            
            difference22.SetActive(true);
           
            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
            else
            {
                diffound = diffound + 1;
            }
        }
        public void finddifference3()
        {
            difference3.SetActive(true);
            button3.SetActive(false);
            button33.SetActive(false);
            
            difference33.SetActive(true);
            
            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
            else
            {
                diffound = diffound + 1;
            }
        }

        public void finddifference4()
        {
            difference4.SetActive(true);
            button4.SetActive(false);
            button44.SetActive(false);
            
            difference44.SetActive(true);

            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
            else
            {
                diffound = diffound + 1;
            }
        }

        public void finddifference5()
        {
            difference5.SetActive(true);
            button5.SetActive(false);
            button55.SetActive(false);

            difference55.SetActive(true);

            if (diffound == 5)
            {
                gameendui.SetActive(true);
            }
            else
            {
                diffound = diffound + 1;
            }
        }

        public void end()
        {
            difference1.SetActive(false);
            difference11.SetActive(false);
            button1.SetActive(true);
            button11.SetActive(true);

            difference2.SetActive(false);
            difference22.SetActive(false);
            button2.SetActive(true);
            button22.SetActive(true);

            difference3.SetActive(false);
            difference33.SetActive(false);
            button3.SetActive(true);
            button33.SetActive(true);

            difference4.SetActive(false);
            difference44.SetActive(false);
            button4.SetActive(true);
            button44.SetActive(true);

            difference5.SetActive(false);
            difference55.SetActive(false);
            button5.SetActive(true);
            button5.SetActive(true);

            diffound = 0;

            gameendui.SetActive(false);
            game.SetActive(false);
        }

    }
}
