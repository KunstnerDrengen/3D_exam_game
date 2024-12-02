using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=_QajrabyTJc&ab_channel=Brackeys
    //Mouse Sens
    public float mouseSens = 100f; 

    //Playerbody
    public Transform PlayerBody; 

    //Rotation x
    float xRoatation = 0f; 


    void Start()
    {
        //Locks cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Get mouse X and Y Axis as a float
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        //Calculates the X rotation
        xRoatation -= mouseY;
        xRoatation = Mathf.Clamp(xRoatation, -90f, 90f);

        //Transform position into X/y Movement
        transform.localRotation = Quaternion.Euler(xRoatation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
