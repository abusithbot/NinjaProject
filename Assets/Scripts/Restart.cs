using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public IntSO snack;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Ca marche bg");
        Time.timeScale = 1;
        snack.value = 0;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
