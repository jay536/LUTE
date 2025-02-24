using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace LoGaCulture.LUTE
{
    public class findmissinglocations : MonoBehaviour
    {
        public List<string> characters = new List<string>();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            characters.Add("cafe");
            characters.Add("dovecote");
            characters.Add("manor");
            characters.Add("farmyard");
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void findcharactercafe()
        {
            characters.Remove("cafe");
        }
        public void findcharacterdove()
        {
            characters.Remove("dovecote");
        }
        public void findcharactermanor()
        {
            characters.Remove("manor");
        }
        public void findcharacterfarm()
        {
            characters.Remove("farmyard");
        }
    }
}
