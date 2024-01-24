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
        if (collision.gameObject.CompareTag("HIM"))
        {
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(true);
            Time.timeScale = 0;
            ops = collision.gameObject;
        }

        if (collision.gameObject.CompareTag("HIM"))
        {
            if (snack.value == 0)
            {
              GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(true); 
              GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false); 
            }
        }
    }

    public void Change()
    {
        if (snack.value == 1)
        {
            snack.value--;
            Time.timeScale = 1;
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false);
            if (ops != null) 
            ops.GetComponent<CapsuleCollider>().enabled = false;
        }
        else if (snack.value == 2)
        {
            snack.value --;
            Time.timeScale = 1;
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false);
            if (ops != null)
            ops.GetComponent<CapsuleCollider>().enabled = false;
        }
        else if (snack.value == 3)
        {
            snack.value --;
            Time.timeScale = 1;
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(false);
            if(ops != null)
            ops.GetComponent<CapsuleCollider>().enabled = false;
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
