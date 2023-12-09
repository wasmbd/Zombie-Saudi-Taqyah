using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AgentFollow : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    public GameObject []Zombies;
    public GameObject[]Bombies;
    private Animator animator;
    public bool IsRunning=false;
    public AudioSource RunSound;//sound of
                                   //zombie talking
    public AudioSource RoarSound;//zombie eating
    public AudioSource TalkZombie;
    //music afer circle

    //public Button button;

    void Start()
    {
     /*   button = GetComponent<Button>();
        if (button.)
        {

        }*/
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        StartCoroutine(DelayedFollow());
    }

    void Update()
    {
        // Your update logic here
    }

    IEnumerator DelayedFollow()
    {
       // yield return new WaitForSeconds(2f);
        // IsRunning = true;
       // animator.SetTrigger("RUUN");
        yield return new WaitForSeconds(24f);//Adjust the delay duration as needed
        if (target != null)
        {
            animator.SetTrigger("RUUN");
            agent.destination = target.position;
            TalkZombie.Play();
            yield return new WaitForSeconds(4f);
            TalkZombie.Stop();
            RunSound.Play();
            yield return new WaitForSeconds(1f);
            RoarSound.Play();

            //nimator.SetBool("IsRunning", true);
            ///////////////////
        }
        yield return new WaitForSeconds(5f);
        foreach (GameObject go in Zombies)
        {
            
            go.SetActive(true);
           // animator.SetTrigger("RUUN");
            yield return new WaitForSeconds(2f);
        }

        yield return new WaitForSeconds(5f);
        foreach (GameObject go in Bombies)
        {

            go.SetActive(false);
            // animator.SetTrigger("RUUN");
        }


    }

    /* public Transform destinationPoint;
public Transform player;
public float attackDistance = 2.0f;

private NavMeshAgent agent;
private Animator animator;

void Start()
{
    agent = GetComponent<NavMeshAgent>();
    animator = GetComponent<Animator>();
    agent.autoBraking = false;
}

void Update()
{
    // Check if player is within attack distance
    float distanceToPlayer = Vector3.Distance(transform.position, player.position);
    if (distanceToPlayer <= attackDistance)
    {
        // Play attack animation
        animator.SetTrigger("IsAttacking");
       // agent.isStopped = true;
        return;
    }

    // Check if player has reached the destination point
    if (Vector3.Distance(transform.position, destinationPoint.position) <= 1.0f)
    {
        // Play run animation
        animator.SetBool("IsRunning", true);

        // Set the player's position as the destination
        agent.SetDestination(player.position);
        agent.autoBraking = true;
    }
}*/
}
