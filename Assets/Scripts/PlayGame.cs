using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
  public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }

  public void Quit()
    {
        Application.Quit();
    }
}
