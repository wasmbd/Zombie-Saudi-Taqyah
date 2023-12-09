using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow2 : MonoBehaviour
{

    public Transform target;
    Vector3 theDestination;
    NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        // Cache agent component and destination
        agent = GetComponent<NavMeshAgent>();
        theDestination = agent.destination;

        // Get the Animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Update destination if the target moves one unit
        if (Vector3.Distance(theDestination, target.position) > 2.0f)
        {
            theDestination = target.position;
            agent.destination = theDestination;

            // Trigger the "RUUN" animation
            animator.SetTrigger("RUUN");
        }
    }
}
