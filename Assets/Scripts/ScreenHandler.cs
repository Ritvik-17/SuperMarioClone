using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenHandler : MonoBehaviour
{

    public void RestartLevel(){
        Instantiate();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RedirectToHome(){
        Instantiate();
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void StartGame(){
        Instantiate();
        SceneManager.LoadScene(1);
    }

    public void Quit(){
        Application.Quit();
    }

    void Instantiate(){
        Time.timeScale = 1f;
    }
}
