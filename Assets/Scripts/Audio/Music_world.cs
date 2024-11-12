using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_world : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Audionew>().Play("Music");
    }

    //for sfx
    //Soundmaneger.Instance.PlaySound3D("wew", transform.position);
}
