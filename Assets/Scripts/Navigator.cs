using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    public float rotationSpeed = 5f;

    void Start()
    {
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
            // Move towards the target
            agent.SetDestination(target.position);

            // Calculate the direction to the target
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // Keep rotation horizontal

            if (directionToTarget != Vector3.zero)
            {
                // Calculate rotation to face the target with a 90-degree Y offset
                Quaternion targetRotation = Quaternion.LookRotation(directionToTarget) * Quaternion.Euler(0, 90, 0);

                // Smoothly rotate the agent to face the target
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
        }
    }
}


