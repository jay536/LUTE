using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class findgame1 : MonoBehaviour
    {
        public GameObject notfind;
        public GameObject find;

        public bool notfindbool;

        public GameObject game;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            notfindbool = false;
            notfind.SetActive(false);
            find.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void notfinditem()
        {
            notfind.SetActive(true);
            notfindbool = true;
            StartCoroutine(waitforseconds());
        }

        public void finditem()
        {
            notfind.SetActive(false);
            find.SetActive(true);
        }

        public void close()
        {
            game.SetActive(false);
        }
        IEnumerator waitforseconds()
        {
            if (notfindbool == true)
            {
                yield return new WaitForSeconds(2);
                notfind.SetActive(false);
                notfindbool = false;
            }

         

        }
    }
}
