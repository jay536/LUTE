using System;
using JetBrains.Annotations;
using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class decorationcreation : MonoBehaviour
    {

        public GameObject gameui;
        public GameObject colour1;
        public GameObject colour2;
       
        public GameObject gametext;
        public GameObject endgametext;
        public GameObject endgamebutton;
        public GameObject finishcreationbutton;

        public GameObject game;

        public GameObject[] background1;
        public GameObject[] background2;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void finishcreation()
        {
            gameui.SetActive(false);
            colour1.SetActive(false);
            colour2.SetActive(false);
            gametext.SetActive(false);
            finishcreationbutton.SetActive(false);

            endgametext.SetActive(true);
            endgamebutton.SetActive(true);

            foreach (GameObject obj in background1)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in background2)
            {
                obj.SetActive(false);
            }

        }

        public void close()
        {
            gameui.SetActive(true);
            colour1.SetActive(true);
            colour2.SetActive(true);
            gametext.SetActive(true);
            finishcreationbutton.SetActive(true);

            endgametext.SetActive(false);
            game.SetActive(false);
            endgamebutton.SetActive(false);

            foreach (GameObject obj in background1)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in background2)
            {
                obj.SetActive(true);
            }
        }
    }
}
