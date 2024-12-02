using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exittrig : MonoBehaviour
{
    //if the player exits the tr�gger, the game ends
    private void OnTriggerExit(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(3);
    }
}
