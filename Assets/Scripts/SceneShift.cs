using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShift : MonoBehaviour
{
    
  public void Gamescene()
  {
    SceneManager.LoadScene(1);
  }    

  public void Homescene()
  {
    SceneManager.LoadScene(0);
  }   
}

