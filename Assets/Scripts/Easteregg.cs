using Unity.VisualScripting;
using UnityEngine;

public class Easteregg : MonoBehaviour
{
    //Random number
    int RandomNum;

    //Check if easteregg is active
    public bool Easteractive = false;

    //Gameobject to spawn
    public GameObject GoldenBonko;

    void OnTriggerStay(Collider other)
    {
        //If the player entes the easter-egg area, the counter will start
        Counts();
    }
    
    private void Counts()
    {
        //Takes a random number between 1-1000 and displays it in the console
        RandomNum = Random.Range(1, 1000);
        Debug.Log("Random Number: " + RandomNum);
    }

    void Update()
    {
        //if the number becomes 666, Golden grolbonko spawns and plays its sound
        if (RandomNum == 666 && Easteractive == false)
        {
            Easteractive = true; 
            GoldenBonko.SetActive(true); 
            Soundmaneger.Instance_sound.playclips("Goldstatic", transform.position);
        }
        
    }
}
