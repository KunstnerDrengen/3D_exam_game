using UnityEngine;
using System.Collections;

public class lightflicker : MonoBehaviour
{
    //gets Hitdetectionscript
    HitDetection Hitz;

    //Get light
    public Light ligthz;

    //int for random light intensity
    public int lightss;

    //Start/stop light
    public bool lightbreak;

    void Start()
    {
        lightbreak = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Get hitz bool component from player
        Hitz = GameObject.Find("Player").GetComponent<HitDetection>();

        if (lightbreak == false)
        {
            //Start lightflickering
            lightss = Random.Range(0, 10);
            ligthz.intensity = lightss;
        }
        
        if (Hitz.stop == true)
        {
            //When jumpscare is over turn lights off
            StartCoroutine("lightsss");
        }
    }

    public IEnumerator lightsss()
    {
        yield return new WaitForSeconds(2);
        ligthz.intensity = 0.0f; 
        lightbreak = true;
    }
}
