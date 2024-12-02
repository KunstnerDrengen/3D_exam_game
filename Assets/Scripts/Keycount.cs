using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class DisplayInt : MonoBehaviour
{
    //Raycast
    Raycast raycasting; 
    //Exit trigger when keys are found
    public GameObject Exit;

    //Spawning Grolbonko
    public GameObject Evil; 

    //Number of keys
    public int number;

    //Text which shows how many keys are found
    public Text displayText; 

    //Shows the text in the beginning
    public Text starttext;

    //Stops audio for looping
    public bool brek = false;

    void Update()
    {
         raycasting = GameObject.Find("Camera").GetComponent<Raycast>();
         number = raycasting.Keyccount; 
         displayText.text = number.ToString();
         StartCoroutine("Destroytext");

        // if 1 key is found, activate Grolbonko and play scary sfx
        if (number == 1 && brek == false)
        {
            Soundmaneger.Instance_sound.playclips("ScaryStart", transform.position);
            brek = true;
            Evil.SetActive(true); 
        }

        // if 2 key is found, play scary sfx
        if (number == 2 && brek == true)
        {
            brek = false;
            Soundmaneger.Instance_sound.playclips("Scarys1", transform.position);
        }

        // if 3 key is found, activate Exit and play scary sfx
        if (number == 3 && brek == false)
        {
            brek = true;
            Soundmaneger.Instance_sound.playclips("Scarys2", transform.position);
            Exit.SetActive(true);
        }
    }

     public IEnumerator Destroytext()
     {
        //after 10 seconds destroy startext
        yield return new WaitForSeconds(10); 
        Destroy(starttext);
     }
}

