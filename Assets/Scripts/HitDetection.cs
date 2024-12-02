using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitDetection : MonoBehaviour
{
    //Call to eastereggscript
    Easteregg Easters;

    //Gameobject and camera assignments
    public GameObject panel;
    public Camera cam1;
    public Camera cam2;
    public Camera Easter;

    //Stop bool to stop audio for repeating
    public bool stop;

    // Jumpscare on/off
    public bool Jumpscareanim = false;

    private void Start()
    {
        //Enable certain camera and setting the others false
        cam1.enabled = false;
        cam2.enabled = true;
        stop = false;
        //PLay Scary audio from the audio manager
        FindObjectOfType<Audionew>().Play("scarys");

    }

    public void Update()
    {
        //Get Golden grolbonko/easteregg gameobject
        Easters = GameObject.Find("Easteregg").GetComponent<Easteregg>();
    }

    void OnCollisionEnter(Collision collision)
    {
        //Checks if either grolbonko or golden grolbonko hits the player, and then plays certain jumpscare
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
        //PLays jumpscare, enables the right camera and wait for the jumpscare to end, before going to Game over screen
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
        yield return new WaitForSeconds(7); 
        SceneManager.LoadScene(2);
    }

    private IEnumerator Jumpscare_gold()
    {
        //PLays jumpscare, enables the right camera and wait for the jumpscare to end, before closing the game
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
