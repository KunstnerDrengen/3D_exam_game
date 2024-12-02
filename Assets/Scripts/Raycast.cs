using UnityEngine;

public class Raycast : MonoBehaviour
{
    //Get keycount for player
    public int Keyccount = 0;

    void FixedUpdate()
    {
        //Set bool when E is pressed
        bool isInteract = Input.GetKeyDown(KeyCode.E);

        //Set destination of raycast
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        //Draw raycast
        RaycastHit hit;
        Debug.DrawRay(transform.position, fwd * 3, Color.red);

        //Chat GPT helped with this section:
        // Perform the raycast and check for a hit within 10 units
        if (Physics.Raycast(transform.position, fwd, out hit, 10))
        {
            print("There is something in front of the object!");

            // Check if the e key is pressed
            if (isInteract)
            {
                Debug.Log("E pressed");
                // Check if the object in front has the tag "key"
                if (hit.collider.CompareTag("Key"))
                {
                    // Destroy the object with the "key" tag
                    Destroy(hit.collider.gameObject);

                    print("Key object destroyed!");
                    //Keycount is + 1
                    Keyccount = Keyccount + 1;
                }
            }
        }
    }
}

