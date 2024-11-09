using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour
{
    public Light Lighter; 
    public Light PLayerLighter; 
    public bool toggle = false; 

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && toggle == false)
        {
            PLayerLighter.enabled = true;
            Lighter.enabled = true;
            StartCoroutine(DelayON());
        }
        else if (Input.GetKey(KeyCode.Mouse0) && toggle == true)
        {
            PLayerLighter.enabled = false;
            Lighter.enabled = false;
            StartCoroutine(DelayOFF());
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
