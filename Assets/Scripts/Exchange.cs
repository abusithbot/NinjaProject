using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exchange : MonoBehaviour
{
    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        Debug.Log("collision exit");
        if (collision.gameObject.CompareTag("HIM"))
        {
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(true);
            Time.timeScale = 0;
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
