using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindHat : MonoBehaviour
{
    
        private void Update()
        {
            // Check if the left mouse button is clicked
            if (Input.GetMouseButtonDown(0))
            {
                // Create a ray from the mouse position
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                // Check if the ray hits a game object
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    if(hit.collider.gameObject.tag=="Hat")
                    {
                        Debug.Log("Congtraz you found the hat ");
                    TopGameManager.Instance.Level[1].SetActive(false);
                    }
                    else if(hit.collider.gameObject.tag == "Cat")
                    {
                        Debug.Log("Its not the hat its a " + hit.collider.gameObject.tag);
                    }
                    else if (hit.collider.gameObject.tag == "Ball")
                    {
                        Debug.Log("Its not the hat its a " + hit.collider.gameObject.tag);
                    }
                    else if (hit.collider.gameObject.tag == "Basket")
                    {
                        Debug.Log("Its not the hat its a " + hit.collider.gameObject.tag);
                    }
                        // Display the name of the clicked game object in the console
                       /* Debug.Log("Clicked: " + hit.collider.gameObject.name);*/
                }
            }
        }
    
}
