using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class info : MonoBehaviour
{
    //Gamobject call
    public GameObject Infos;
    //Time for info
    public float times = 10.0f;

    //Bool for info is gone
    public bool infogone;

    void Start()
    {
        //Set info false
        Infos.SetActive(false);
        infogone = false;
    }

    void Update()
    {
        //Activates info after 10 seaconds. if "Q" is pressed, info gets deleted
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
