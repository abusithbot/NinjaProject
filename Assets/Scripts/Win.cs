using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //  Debug.Log("yes bb");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision enter");
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Canvas").transform.Find("Winner").gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Canvas").transform.Find("Winner").gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
