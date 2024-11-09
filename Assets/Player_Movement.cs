using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Player_Movement : MonoBehaviour
{

    public CharacterController controller; 

    public float playerspeed;
    public float targetTime = 5.0f;

    public bool tired = false;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool sprinter = Input.GetKey(KeyCode.LeftShift);
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move *playerspeed * Time.deltaTime);

        if ((sprinter == true && targetTime > 0.0f))
        {
          playerspeed = 6f;
          targetTime -= Time.deltaTime;
          if (targetTime <= 0)
            {
                targetTime = 0.0f;
                Debug.Log("tired");
                playerspeed = 3f;
            }
        }
        else if (sprinter == false)
        {
            playerspeed = 3f;
            targetTime += Time.deltaTime;
            if (targetTime >= 5)
            {
                targetTime = 5.0f;
                Debug.Log("full");
            }
        }
    }
}

        
