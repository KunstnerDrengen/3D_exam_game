using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    //Speed for player
    public float baseSpeed = 3f;
    //Sprintspeed for player
    public float sprintSpeed = 6f;
    // Maximum stamina
    public float stamina = 5f;
    // Start with full stamina
    public float targetTime = 5f; 
    //Playerspeed float
    private float playerspeed;
    // Track if stamina is depleted
    public bool isExhausted = false; 
    
    void Update()
    {
        // Handle movement input. gets x and y axis
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Chat gpt used for A PART of this section

        //bool for when Sprint is on 
        bool isSprinting = Input.GetKey(KeyCode.LeftShift);

        //Movement for player
        Vector3 move = transform.right * x + transform.forward * z;
        
        // Stamina and sprint logic
        if (isSprinting && !isExhausted && targetTime > 0.0f)
        {
            playerspeed = sprintSpeed;
            targetTime -= Time.deltaTime;  // Decrease stamina over time
            
            if (targetTime <= 0)
            {
                targetTime = 0;
                isExhausted = true; // Set to exhausted state
                Debug.Log("Tired - Recharging Stamina");
            }
        }
        else
        {
            playerspeed = baseSpeed;

            // Recover stamina over time, even if Shift is still held
            targetTime += Time.deltaTime;
            targetTime = Mathf.Clamp(targetTime, 0, stamina); // Keep targetTime within stamina limits
            
            // Reset exhaustion if stamina fully recharged
            if (targetTime >= stamina)
            {
                isExhausted = false;
                //Debug.Log("Stamina full");
            }
        }

        // Move the player
        controller.Move(move * playerspeed * Time.deltaTime);
    }
}

        
