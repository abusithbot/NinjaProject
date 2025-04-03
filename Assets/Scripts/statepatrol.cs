using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePatrol : StateMachineBehaviour
{
    private Routine routine;
    private float timer;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        routine = animator.GetComponent<Routine>();
        if (routine != null)
        {
            routine.GoToNextPoint();
        }
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        if (routine != null && !routine.isChasing)
        {
            if (routine.agent.remainingDistance <= 1f)
            {
                routine.GoToNextPoint();
            }
        }
    }
}
