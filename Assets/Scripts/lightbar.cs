using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightbar : MonoBehaviour
{
    Flashlight flasher;
    public Image Barlig;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flasher = GameObject.Find("Player").GetComponent<Flashlight>();
        Barlig = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Barlig.fillAmount = flasher.lightstamina / 120f;

        if (flasher.lightstamina >= 80f)
        {
            Barlig.GetComponent<Image>().color = new Color(0,255,0);
        }
        else if (flasher.lightstamina >= 40f && flasher.lightstamina < 80f)
        {
            Barlig.GetComponent<Image>().color = new Color(255,255,0);
        }
        else if (flasher.lightstamina < 40f)
        {
            Barlig.GetComponent<Image>().color = new Color(255,0,0);
        }
    }
}
