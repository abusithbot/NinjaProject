using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public IntSO snack;
    public TextMeshProUGUI snackui;
    public void Next(string Level)
    {
        SceneManager.LoadScene(Level);
        Time.timeScale = 1f;
        snack.value = 0;
    }
    
}
