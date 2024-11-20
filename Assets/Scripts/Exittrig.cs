using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exittrig : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(3);
    }
}
