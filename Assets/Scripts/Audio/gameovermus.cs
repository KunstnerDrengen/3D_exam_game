using UnityEngine;

public class gameovermus : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindObjectOfType<Audionew>().Play("avscar");
    }
}
