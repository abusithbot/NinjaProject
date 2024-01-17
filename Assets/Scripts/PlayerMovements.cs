using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Vector3 direction = new Vector3(); //direction du joueur
    private Transform cameraTransform;
    private Rigidbody rb;
    public float movespeed = 5;
    public float gravity = 5;
    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {                               //Deplacement Avant Arriere(relatif a la camera)       //Deplacement Gauche Droite (relatif au player)
        //direction = (cameraTransform.forward * Input.GetAxis("Vertical") + cameraTransform.right * Input.GetAxis("Horizontal")) * movespeed;
        direction = cameraTransform.forward * Input.GetAxis("Vertical") + cameraTransform.right * Input.GetAxis("Horizontal");
        direction.y = 0;
    }

    private void FixedUpdate()
    {
        direction.y = rb.velocity.y;
        rb.velocity = direction.normalized * movespeed; //utile
    }
}
