using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timerbar : MonoBehaviour
{
    //Get playermov script
    Player_Movement Playermov;
    //Get timerbar image
    public Image timerBar;

    //Get playercomponent and timerbar image
    void Start()
    {
        Playermov = GameObject.Find("Player").GetComponent<Player_Movement>();
        
        timerBar = GetComponent<Image>();
        
    }

    void Update()
    {
        // Fillamount on timerbar, depending on the sprinttimer from another script
        timerBar.fillAmount = Playermov.targetTime / 5;
        
        //Changes the bars color depending on how much time is left
        if (Playermov.isExhausted == true)
        {
            timerBar.GetComponent<Image>().color = new Color(255,0,0);
        }
        else
        {
            timerBar.GetComponent<Image>().color = new Color(0,255,0);
        }

        if (Playermov.targetTime <= 2.5f && Playermov.isExhausted == false)
        {
            timerBar.GetComponent<Image>().color = new Color(255,255,0);
        }
    }
} 
