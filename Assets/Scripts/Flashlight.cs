using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
    public Light Lighter; 
    public bool toggle = false; 

    public float lightstamina = 180f;

    // Update is called once per frame
    void Update()
    {
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
