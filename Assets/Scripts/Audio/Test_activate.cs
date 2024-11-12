using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testerin : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<Audionew>().Play("Music");
    }

    void Update()
    {
        //Soundmaneger.Instance.playclips("Goblin_1", transform.position);
    }
}
