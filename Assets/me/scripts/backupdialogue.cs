using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class backupdialogue : MonoBehaviour
    {
        public GameObject game;

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
            game.SetActive(false);
        }
    }
}
