using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    PlayerInput playerinput;
    InputAction moveAction;
    InputAction lookAction;
    [SerializeField] float speed = 8;
    Animator animator;
    Camera mainCamera;

    void Start()
    {
        playerinput = GetComponent<PlayerInput>();
        moveAction = playerinput.actions.FindAction("Move");
        lookAction = playerinput.actions.FindAction("Look");
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        MovePlayer();
        UpdateAnimation();
    }

    void MovePlayer()
    {
        Vector2 directionInput = moveAction.ReadValue<Vector2>();

        // Convertir les entr�es de d�placement en mouvements proportionnels � la cam�ra
        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0f;
        Vector3 cameraRight = mainCamera.transform.right;

        Vector3 movementDirection = (cameraForward * directionInput.y + cameraRight * directionInput.x).normalized;

        // D�placer le joueur
        Vector3 newPosition = transform.position + movementDirection * speed * Time.deltaTime;

        // V�rifier si le nouveau positionnement entra�ne une collision avec un mur
        RaycastHit hit;
        if (Physics.Raycast(transform.position, movementDirection, out hit, speed * Time.deltaTime))
        {
            if (hit.collider.tag == "Wall")
            {
                // Si le joueur va entrer en collision avec un mur, n'autorisez pas le d�placement dans cette direction
                return;
            }
        }

        // Si aucun mur n'est rencontr�, d�placez le joueur
        transform.position = newPosition;

        // Orienter le joueur vers la direction de la cam�ra
        if (movementDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.1f); // Lerp pour une rotation plus douce
        }
    }

    void UpdateAnimation()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        bool isWalking = direction.magnitude > 0.1f; // V�rifie si le joueur est en train de marcher
        animator.SetBool("Walking", isWalking);
    }
}
