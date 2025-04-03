using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public IntSO snack;
    public GameObject ops;
    // Start is called before the first frame update
    
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log("toucher la balance");
         if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ton pere");
            Change();
            Time.timeScale = 0;
            ops = collision.gameObject;
        }
    }   
    public void Change()
    {
        Debug.Log("on est la bg");
        Debug.Log("on est la bg " + snack.value.ToString());
        if (snack.value > 0)
        {
            Debug.Log("clik");
            snack.value--;
            Time.timeScale = 1;
           /* GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(true);*/
            GameObject.Find("Canvas").transform.Find("Exchange").gameObject.SetActive(true);
            if (ops != null) 
            ops.GetComponent<CapsuleCollider>().enabled = false;
        }
        else 
        {
            Debug.Log("0");
            snack.value--;
            Time.timeScale = 1;
            GameObject.Find("Canvas").transform.Find("GameOver").gameObject.SetActive(true);
            if (ops != null)
                ops.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}