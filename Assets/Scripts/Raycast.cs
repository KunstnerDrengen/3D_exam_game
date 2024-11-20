using UnityEngine;

public class Raycast : MonoBehaviour
{
    public int Keyccount = 0;
    void FixedUpdate()
    {
        bool isInteract = Input.GetKeyDown(KeyCode.E);
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;
        Debug.DrawRay(transform.position, fwd * 3, Color.red);

        // Perform the raycast and check for a hit within 10 units
        if (Physics.Raycast(transform.position, fwd, out hit, 10))
        {
            print("There is something in front of the object!");

            // Check if the e key is pressed
            if (isInteract)
            {
                Debug.Log("huha");
                // Check if the object in front has the tag "key"
                if (hit.collider.CompareTag("Key"))
                {
                    // Destroy the object with the "key" tag
                    Destroy(hit.collider.gameObject);

                    print("Key object destroyed!");
                    Keyccount = Keyccount + 1;
                }
            }
        }
    }
}

