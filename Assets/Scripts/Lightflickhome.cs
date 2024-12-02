using UnityEngine;

public class Lightflickhome : MonoBehaviour
{

    public Light ligthz;

    public int lightss;

    void Start()
    {
        //Play music
        FindObjectOfType<Audionew>().Play("intro");
    }

    // Update is called once per frame
    void Update()
    {
        //flicker lights
        lightss = Random.Range(50, 100);
        ligthz.range = lightss;
    }
}
