using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class dressUp1 : MonoBehaviour
    {
        public GameObject game;

        public GameObject underdress;

        public GameObject dress1;
        public GameObject dress2;
        public GameObject dress3;
        
        public GameObject hat1;
        public GameObject hat2;
        public GameObject hat3;
        public GameObject hat4;

        public bool wearingd1;
        public bool wearingd2;
        public bool wearingd3;

        public bool wearingh1;
        public bool wearingh2;
        public bool wearingh3;
        public bool wearingh4;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            wearingd1 = false;
            wearingd2 = false;
            wearingd3 = false;
        }

        // Update is called once per frame
        void Update()
        {
        if (wearingd3 == true && wearingh3 == true)
            {
                hat4.SetActive(true);
                hat3.SetActive(false);
            }
        else if (wearingh3 == true && wearingd3 == false)
            {
                hat3.SetActive(true);
                hat4.SetActive(false);
            }
        }
        public void addskirt1()
        {
            if (wearingd1 == false)
            {
                dress1.SetActive(true);
                dress2.SetActive(false);
                dress3.SetActive(false);
                underdress.SetActive(false);
                wearingd1 = true;
                wearingd2 = false;
                wearingd3 = false;
            }
            else if (wearingd1 == true)
            {
                dress1.SetActive(false);
                dress2.SetActive(false);
                dress3.SetActive(false);
                underdress.SetActive(true);
                wearingd1 = false;
            }
        }

        public void addskirt2()

        {
            if (wearingd2 == false)
            {
                dress1.SetActive(false);
                dress2.SetActive(true);
                dress3.SetActive(false);
                underdress.SetActive(false);
                wearingd1 = false;
                wearingd2 = true;
                wearingd3 = false;
            }
            else if (wearingd2 == true)
            {
                dress1.SetActive(false);
                dress2.SetActive(false);
                dress3.SetActive(false);
                underdress.SetActive(true);
                wearingd2 = false;
            }
        }

        public void addskirt3()

        {
            if (wearingd3 == false)
            {
                dress1.SetActive(false);
                dress2.SetActive(false);
                dress3.SetActive(true);
                underdress.SetActive(false);
                wearingd1 = false;
                wearingd2 = false;
                wearingd3 = true;
            }
            else if (wearingd3 == true)
            {
                dress1.SetActive(false);
                dress2.SetActive(false);
                dress3.SetActive(false);
                underdress.SetActive(true);
                wearingd3 = false;
            }
        }


        public void addhat1()

        {
            if (wearingh1 == false)
            {
                hat1.SetActive(true);
                hat2.SetActive(false);
                hat3.SetActive(false);
                hat4.SetActive(false);
                wearingh1 = true;
                wearingh2 = false;
                wearingh3 = false;
            }
            else if (wearingh1 == true)
            {
                hat1.SetActive(false);
                hat2.SetActive(false);
                hat3.SetActive(false);
                wearingh1 = false;
            }
        }
        public void addhat2()

        {
            if (wearingh2 == false)
            {
                hat1.SetActive(false);
                hat2.SetActive(true);
                hat3.SetActive(false);
                hat4.SetActive(false);
                wearingh1 = false;
                wearingh2 = true;
                wearingh3 = false;
            }
            else if (wearingh2 == true)
            {
                hat1.SetActive(false);
                hat2.SetActive(false);
                hat3.SetActive(false);
                wearingh2 = false;
            }
        }
        public void addhat3()

        {
            if (wearingh3 == false)
            {
                hat1.SetActive(false);
                hat2.SetActive(false);
                hat3.SetActive(true);
                wearingh1 = false;
                wearingh2 = false;
                wearingh3 = true;
            }
            else if (wearingh3 == true)
            {
                hat1.SetActive(false);
                hat2.SetActive(false);
                hat3.SetActive(false);
                hat4.SetActive(false);
                wearingh3 = false;
            }
        }


        public void finish()
        {
            game.SetActive(false);
        }
    }
}

