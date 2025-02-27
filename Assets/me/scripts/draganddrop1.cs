using UnityEngine;
using UnityEngine.Rendering;

namespace LoGaCulture.LUTE
{
    public class draganddrop1 : MonoBehaviour
    {
        private bool dragging;

        Vector2 offset;

       
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (!dragging) return;



            var mouseposition = getmousepos();

            transform.position = mouseposition - offset;
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
            dragging = false;
        }
    }
}
