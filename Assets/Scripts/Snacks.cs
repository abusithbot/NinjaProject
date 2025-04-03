using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snacks : MonoBehaviour
{

    [SerializeField]
    IntSO snack;
    private void OnTriggerEnter(Collider other)
    {
        if (snack != null && other.CompareTag("Player"))
        {
            snack.ItemCollected();
            gameObject.SetActive(false);
        }
    }
}
