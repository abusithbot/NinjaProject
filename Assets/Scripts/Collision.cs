using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("toucher la balance");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
