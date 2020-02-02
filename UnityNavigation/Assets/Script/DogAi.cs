using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogAi : MonoBehaviour
{
    public Transform aims;
    public NavMeshAgent agent;
    public Animator anim;
    private bool iswalk;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            iswalk = true;
        }

        if (iswalk)
        {
            Move();
        }

        if (agent.hasPath)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }

    public void Move()
    {
        agent.SetDestination(aims.position);

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            aims.GetComponent<aims>().changPosition();

            iswalk = false;
        }
    }
}
