using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{
    Easteregg Easters;

    public GameObject panel;
    public Camera cam1;
    public Camera cam2;
    public Camera Easter;

    public bool stop;

    public bool Jumpscareanim = false;

    private void Start()
    {
        cam1.enabled = false;
        cam2.enabled = true;
        stop = false;
    }

    public void Update()
    {
        Easters = GameObject.Find("Easteregg").GetComponent<Easteregg>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Evil")
        {
            Cursor.lockState = CursorLockMode.None;
            if ( Easters.Easteractive == true)
            {
                StartCoroutine("Jumpscare_gold");
            }
            else if ( Easters.Easteractive == false)
            {
                StartCoroutine("Jumpscare");
            }
            
        }
    }

    private IEnumerator Jumpscare()
    {
        Jumpscareanim = true;
        if (stop == false)
        {
            Soundmaneger.Instance_sound.playclips("Jumpscare", transform.position);
            stop = true;
        }
        Destroy(panel);
        cam1.enabled = true;
        cam2.enabled = false;
        Easter.enabled = false;
        yield return new WaitForSeconds(2); 
        SceneManager.LoadScene(2);
    }

    private IEnumerator Jumpscare_gold()
    {
        Jumpscareanim = true;
        if (stop == false)
        {
            Soundmaneger.Instance_sound.playclips("Jumpscare_Gold", transform.position);
            stop = true;
        }
        Destroy(panel);
        cam1.enabled = false;
        cam2.enabled = false;
        Easter.enabled = true;
        yield return new WaitForSeconds(5); 
        Application.Quit();
    }
}
