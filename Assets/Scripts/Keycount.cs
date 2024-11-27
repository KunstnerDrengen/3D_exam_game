using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class DisplayInt : MonoBehaviour
{
    Raycast raycasting; 
    public GameObject Exit;

    public GameObject Evil; 
    public int number; // The integer you want to display
    public Text displayText; // Reference to the Text component

    public Text starttext;

    public bool brek = false;

    void Update()
    {
         raycasting = GameObject.Find("Camera").GetComponent<Raycast>();
         number = raycasting.Keyccount; 
         displayText.text = number.ToString();
         StartCoroutine("Destroytext");

        if (number == 1 && brek == false)
        {
            Soundmaneger.Instance_sound.playclips("ScaryStart", transform.position);
            brek = true;
            Evil.SetActive(true); 
        }

        if (number == 2 && brek == true)
        {
            brek = false;
            Soundmaneger.Instance_sound.playclips("Scarys1", transform.position);
        }

        if (number == 3 && brek == false)
        {
            brek = true;
            Soundmaneger.Instance_sound.playclips("Scarys2", transform.position);
            Exit.SetActive(true);
        }
    }

     public IEnumerator Destroytext()
     {
        yield return new WaitForSeconds(10); 
        Destroy(starttext);
     }
}

