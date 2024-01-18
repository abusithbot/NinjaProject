using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    TextMeshProUGUI T;
    public IntSO snack;
    public TextMeshProUGUI snackui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        snackui.text = snack.value.ToString();
    }
}
