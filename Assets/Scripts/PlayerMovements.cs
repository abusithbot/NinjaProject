using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Vector3 direction = new Vector3(); //direction du joueur
    private Transform cameraTransform;
    private Rigidbody rb;
    public float movespeed = 5;
    public float gravity = 200;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {                               //Deplacement Avant Arriere(relatif a la camera)       //Deplacement Gauche Droite (relatif au player)
        //direction = (cameraTransform.forward * Input.GetAxis("Vertical") + cameraTransform.right * Input.GetAxis("Horizontal")) * movespeed;
        direction = cameraTransform.forward * Input.GetAxis("Vertical") + cameraTransform.right * Input.GetAxis("Horizontal");
        direction.y = 0;

        if (direction.magnitude > 0)
        {
            Vector3 lookDirection = cameraTransform.forward;
            lookDirection.y = 0;
            Quaternion rotation = Quaternion.LookRotation(lookDirection);
            rotation = Quaternion.RotateTowards(rb.rotation, rotation, movespeed);
            rb.rotation = rotation;

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetBool("Walking", true);
            Debug.Log("ok");
        }
        else
        {
            animator.SetBool("Walking", false);
        }

    }

    private void FixedUpdate()
    {
        direction.y = rb.velocity.y;
        rb.velocity = direction.normalized * movespeed; //utile
    }
}
