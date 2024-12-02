using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour
{
    //Player position for Grolbonko
    public Transform target;
    //Navmeshagent
    private NavMeshAgent agent;
    //Rotationspeed for Grolbonko
    public float rotationSpeed = 5f;

    void Start()
    {
        //Get the navmeshagent when the script starts
        agent = GetComponent<NavMeshAgent>();

        if (target == null)
        {
            Debug.LogError("no target");
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Move towards the player
            agent.SetDestination(target.position);

            // Calculate the direction to the player
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // Keep rotation horizontal

            if (directionToTarget != Vector3.zero)
            {
                //Chatgpt helped with this part:
                // Calculate rotation to face the player with a 90-degree Y offset, so it faces the players position
                Quaternion targetRotation = Quaternion.LookRotation(directionToTarget) * Quaternion.Euler(0, 90, 0);

                // Smoothly rotate the agent to face the player
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
        }
    }
}


