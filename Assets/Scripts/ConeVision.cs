using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ConeVision : MonoBehaviour
{
    [SerializeField]
    private LayerMask playerLayer;

    [HideInInspector]
    public GameObject m_target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("griller");
            Vector3 rayDirection = other.transform.position - transform.position;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, rayDirection, out hit,Mathf.Infinity, playerLayer)) 
            {
              m_target = other.gameObject;
                GetComponentInParent<NavMeshAgent>().SetDestination(other.transform.position);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_target = null;
        }
    }
}
