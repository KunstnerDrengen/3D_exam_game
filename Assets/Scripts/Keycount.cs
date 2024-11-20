using UnityEngine;
using UnityEngine.UI;

public class DisplayInt : MonoBehaviour
{
    Raycast raycasting; 
    public int number; // The integer you want to display
    public Text displayText; // Reference to the Text component

    void Update()
    {
        number = raycasting.Keyccount; 
        raycasting = GetComponent<Raycast>();
        displayText.text = number.ToString();
    }
}

