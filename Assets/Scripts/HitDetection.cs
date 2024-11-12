using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{
    public GameObject panel;
    public Camera cam1;
    public Camera cam2;

    private void Start()
    {
        cam1.enabled = false;
        cam2.enabled = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Evil")
        {
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine("Jumpscare");
        }
    }

    private IEnumerator Jumpscare()
    {
        Destroy(panel);
        cam1.enabled = true;
        cam2.enabled = false;
        yield return new WaitForSeconds(5); 
        SceneManager.LoadScene(2);
    }
}
