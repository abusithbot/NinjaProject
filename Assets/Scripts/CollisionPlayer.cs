using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayer : MonoBehaviour
{
    public IntSO snack;
    public GameObject ops;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Snitch"))
        {
            Debug.Log("ton pere");
            Time.timeScale = 0;
            ficha();
        }
    }
    public void ficha ()
    {
        if (snack.value > 0) // ou cas par cas = || altgr 6
        {
            Debug.Log("clik");
            //GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(true);            
        }
        else
        {
            Debug.Log("0");
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(true);
        }
    }
    public void Change()
    {
        if (snack.value > 0)
        {
            Debug.Log("clik");              
            if (ops != null) 
            ops.GetComponent<CapsuleCollider>().enabled = false;
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false);
            snack.value--;

        }
        else
        {
            Debug.Log("0");
            if (ops != null)
                ops.GetComponent<CapsuleCollider>().enabled = false;
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false);
        }
        Time.timeScale = 1;
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
