using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneShift : MonoBehaviour
{
  
    //changes scenes between Home and game. Also exits the application 
  public void Gamescene()
  {
    SceneManager.LoadScene(1);
  }    

  public void Homescene()
  {
    SceneManager.LoadScene(0);
  }   

  public void Exitgame()
  {
    Application.Quit(); 
  }
}

