using UnityEngine;
using UnityEngine.UI;

public class DisplayInt : MonoBehaviour
{
    Raycast raycasting; 
    public int number; // The integer you want to display
    public Text displayText; // Reference to the Text component

    void Start()
    {
        raycasting = GetComponent<Raycast>();
        UpdateText(); // Update the text initially

    }

    void Update()
    {
        number = raycasting.Keyccount; 
    }

    void UpdateText()
    {
        displayText.text = number.ToString(); // Convert the integer to a string and display it
    }

    // Optionally, you can update the number and refresh the display dynamically
    public void UpdateNumber(int newNumber)
    {
        number = newNumber;
        UpdateText();
    }
}

