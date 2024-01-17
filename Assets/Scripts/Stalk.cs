using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Routine : MonoBehaviour
{
    [SerializeField]
    private Transform[] _Ronde;
    [SerializeField]
    private bool GoBack = false;
    private bool isgoing = true;
    private NavMeshAgent agent;
    private int currentPoint = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        agent.SetDestination(_Ronde[currentPoint].position); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GoBack)
        {
            if(isgoing)
            {
             GoToNextPoint();
            }
            else
            {
                GoToPrevioustPoint();
            }
        }
        else
        {
            GoToNextPoint();
        }
    }

    private void GoToNextPoint()
    {
        if (agent.remainingDistance <= 1f)
        {
            currentPoint++;

            if (currentPoint >= _Ronde.Length)
            {
                if(GoBack)
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
    }private void GoToPrevioustPoint()
    {
        if (agent.remainingDistance <= 1f)
        {
            currentPoint--;

            if (currentPoint < 0 )
            {
                if(GoBack)
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
}
