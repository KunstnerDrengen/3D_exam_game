using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exittrig : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("pik");
        
        //SceneManager.LoadScene(3);
    }
}
