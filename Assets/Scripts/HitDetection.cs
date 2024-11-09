using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Evil")
        {
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
