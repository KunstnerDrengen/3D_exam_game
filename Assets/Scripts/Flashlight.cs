using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
    //ref to light
    public Light Lighter; 

    //public toggle bool
    public bool toggle = false; 

    //Time for the light
    public float lightstamina = 180f;

    void Update()
    {
        //If mouse is clicked the light turns on and the lighttimer goes down, if not the lighttimer stops and the light is turned off
       
        if (Input.GetKey(KeyCode.Mouse0) && toggle == false )
        {
            Lighter.enabled = true;
            
            StartCoroutine(DelayON());
        }
        else if (Input.GetKey(KeyCode.Mouse0) && toggle == true)
        {
            Lighter.enabled = false;
            
            StartCoroutine(DelayOFF());
        }

        if (Lighter.enabled == true)
        {
            lightstamina -= Time.deltaTime;
            Lighter.intensity = lightstamina /10;
        }
    }

    //Delay for the flashligt, so it cant be spammed ON/OFF
    IEnumerator DelayON()
    {
        yield return new WaitForSeconds(1);
        toggle = true;  
    }

    IEnumerator DelayOFF()
    {
        yield return new WaitForSeconds(1);
        toggle = false;
    }
}
