using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayer : MonoBehaviour
{

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
      //  Debug.Log("yes bb");
    }

    private void OnCollisionExit(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("HIM"))
        {
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(true);
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
