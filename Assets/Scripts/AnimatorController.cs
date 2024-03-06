using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private PlayerMovements Movements;
    public Animator animator;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetKey("z"))
        {
            animator.SetBool("Waling", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
        
       /* if (animator)
        {
            animator.SetBool("Walkin",(Movements.true);
            animator.SetBool("Walkin",(Movements.false);
        }*/
    }
}
