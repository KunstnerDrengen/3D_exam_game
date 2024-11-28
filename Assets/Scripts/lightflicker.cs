using UnityEngine;
using System.Collections;

public class lightflicker : MonoBehaviour
{
    HitDetection Hitz;
    public Light ligthz;
    public int lightss;

    public bool lightbreak;

    void Start()
    {
        lightbreak = false;
    }
    // Update is called once per frame
    void Update()
    {
        Hitz = GameObject.Find("Player").GetComponent<HitDetection>();
        if (lightbreak == false)
        {
            lightss = Random.Range(0, 10);
            ligthz.intensity = lightss;
        }
        
        if (Hitz.stop == true)
        {
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
