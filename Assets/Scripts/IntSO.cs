using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[CreateAssetMenu(fileName = "PlayerInventory")]

public class IntSO : ScriptableObject
{
    [SerializeField]
    public int value;
    private void OnEnable()
    {
        value = 0;
    }

    public void ItemCollected()
    {
        value++;
        Debug.Log(value);
    }

}
