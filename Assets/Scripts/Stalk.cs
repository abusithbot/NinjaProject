using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Routine : MonoBehaviour
{
    public Transform[] _Ronde;
    public bool GoBack = false;
    private bool isgoing = true;
    public bool isChasing = false;
    public NavMeshAgent agent;
    public int currentPoint = 0;
    public ConeVision ConeVision;
    private Animator animator;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        ConeVision = GetComponentInChildren<ConeVision>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        agent.SetDestination(_Ronde[currentPoint].position);
    }

    void Update()
    {
        if (ConeVision.m_target != null && !isChasing)
        {
            animator.SetBool("isChasing", true);
            isChasing = true;
        }
        else if (ConeVision.m_target == null && isChasing)
        {
            animator.SetBool("isChasing", false);
            isChasing = false;
        }

        if (!isChasing)
        {
            if (GoBack)
            {
                if (isgoing)
                {
                    GoToNextPoint();
                }
                else
                {
                    GoToPreviousPoint();
                }
            }
            else
            {
                GoToNextPoint();
            }
        }
        else
        {
            ChaseTarget();
        }
    }

    public void GoToNextPoint()
    {
        if (agent.remainingDistance <= 1f)
        {
            currentPoint++;

            if (currentPoint >= _Ronde.Length)
            {
                if (GoBack)
                {
                    isgoing = false;
                    currentPoint = _Ronde.Length - 1;
                }
                else
                {
                    currentPoint = 0;
                }
            }
            agent.SetDestination(_Ronde[currentPoint].position);
        }
    }

    public void GoToPreviousPoint()
    {
        if (agent.remainingDistance <= 1f)
        {
            currentPoint--;

            if (currentPoint < 0)
            {
                if (GoBack)
                {
                    isgoing = true;
                    currentPoint = 0;
                }
                else
                {
                    currentPoint = _Ronde.Length - 1;
                }
            }
            agent.SetDestination(_Ronde[currentPoint].position);
        }
    }

    public void ChaseTarget()
    {
        if (ConeVision.m_target != null)
        {
            agent.SetDestination(ConeVision.m_target.transform.position);
        }
    }
}
