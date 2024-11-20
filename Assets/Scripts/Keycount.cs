using UnityEngine;
using UnityEngine.UI;

public class DisplayInt : MonoBehaviour
{
    Raycast raycasting; 
    public GameObject Exit;

    public GameObject Evil; 
    public int number; // The integer you want to display
    public Text displayText; // Reference to the Text component

    public bool brek = false;

    void Update()
    {
         raycasting = GameObject.Find("Camera").GetComponent<Raycast>();
         number = raycasting.Keyccount; 
         displayText.text = number.ToString();

        if (number == 1 && brek == false)
        {
            Soundmaneger.Instance_sound.playclips("ScaryStart", transform.position);
            brek = true;
            Evil.SetActive(true); 
        }

        if (number == 3)
        {
            Exit.SetActive(true);
        }
    }

    
}

