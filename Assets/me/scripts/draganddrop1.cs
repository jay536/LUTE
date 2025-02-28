using UnityEngine;
using UnityEngine.Rendering;

namespace LoGaCulture.LUTE
{
    public class draganddrop1 : MonoBehaviour
    {
        private bool dragging, placed;

        public GameObject image;

        Vector2 offset;
        public GameObject slot;

       
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            slot = GameObject.Find("bin");
        }

        // Update is called once per frame
        void Update()
        {
            if (!dragging) return;



            var mouseposition = getmousepos();

            transform.position = mouseposition - offset;

            if (placed) return;



           
        }

        void OnMouseDown()
        {
            dragging = true;
            offset = getmousepos() - (Vector2)transform.position;
        }


        Vector2 getmousepos()
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }


        private void OnMouseUp()
        {
            //dragging = false;

            if (Vector2.Distance(transform.position, slot.transform.position) < 1)
            {
                transform.position = slot.transform.position;
                placed = true;
                //image.SetActive(false);
                Destroy(image);
            }
            else
            {
                dragging = false;
            }
          
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("bin") && dragging == false)
            {
                image.SetActive(false);
            }
        }
    }
}
