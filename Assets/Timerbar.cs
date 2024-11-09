using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timerbar : MonoBehaviour
{
    Player_Movement Playermov;
    public Image timerBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playermov = GameObject.Find("PLayer").GetComponent<Player_Movement>();
        timerBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        timerBar.fillAmount = Playermov.targetTime / 5;
    }
} 
