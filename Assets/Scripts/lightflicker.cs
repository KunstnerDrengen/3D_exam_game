using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class lightflicker : MonoBehaviour
{
    public Light ligthz;
    public int lightss;

    // Update is called once per frame
    void Update()
    {
        lightss = Random.Range(0, 10);
        ligthz.intensity = lightss;
    }
}
