using Unity.VisualScripting;
using UnityEngine;

public class Easteregg : MonoBehaviour
{
    int RandomNum;

    public bool Easteractive = false;

    public GameObject GoldenBonko;
    void OnTriggerStay(Collider other)
    {
        Counts();
    }
    
    private void Counts()
    {
        RandomNum = Random.Range(1, 1000);
        Debug.Log("Random Number: " + RandomNum);
    }

    void Update()
    {
        if (RandomNum == 666 && Easteractive == false)
        {
            Easteractive = true; 
            GoldenBonko.SetActive(true); 
            Soundmaneger.Instance_sound.playclips("Goldstatic", transform.position);
        }
        
    }
}
