using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Audionew>().Play("Intro");
        DontDestroyOnLoad(gameObject);
    }
}
