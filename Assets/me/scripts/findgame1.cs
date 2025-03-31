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

        public GameObject v1;
        public GameObject v2;
        public GameObject v3;

        public int randomselect;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            notfindbool = false;
            notfind.SetActive(false);
            find.SetActive(false);
            randomselect = Random.Range(0, 3);
        }

        // Update is called once per frame
        void Update()
        {
        if (randomselect == 0)
            {
                v1.SetActive(true);
                v2.SetActive(false);
                v3.SetActive(false);
            }
        if (randomselect == 1)
            {
                v1.SetActive(false);
                v2.SetActive(true);
                v3.SetActive(false);
            }
        if (randomselect == 2)
            {
                v1.SetActive(false);
                v2.SetActive(false);
                v3.SetActive(true);
            }
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

            randomselect = Random.Range(0, 3);

            notfindbool = false;
            notfind.SetActive(false);
            find.SetActive(false);


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
