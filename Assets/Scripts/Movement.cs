using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    //https://www.youtube.com/watch?v=_QajrabyTJc&ab_channel=Brackeys
    public float mouseSens = 100f; 

    public Transform PlayerBody; 

    float xRoatation = 0f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRoatation -= mouseY;
        xRoatation = Mathf.Clamp(xRoatation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRoatation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
