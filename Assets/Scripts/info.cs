using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class info : MonoBehaviour
{
    public GameObject Infos;
    public float times = 10.0f;

    public bool infogone;

    void Start()
    {
        Infos.SetActive(false);
        infogone = false;
    }

    void Update()
    {
        if (infogone == false)
        {
            times -= Time.deltaTime;
        }
       
        if (times <= 0.0f)
        {
            if (infogone == false)
            {
                Infos.SetActive(true);
            }
            
            if (Input.GetKey(KeyCode.Q))
            {
                Infos.SetActive(false);
                infogone = true;
            }

        }
        
    }
}
