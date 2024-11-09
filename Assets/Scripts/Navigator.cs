using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour
{
    public NavMeshAgent Evilman;
    public Transform PlayerTransform; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Evilman.SetDestination(PlayerTransform.position);
    }
}
