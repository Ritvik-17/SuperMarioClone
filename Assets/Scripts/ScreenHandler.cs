using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenHandler : MonoBehaviour
{

    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RedirectToHome(){
        SceneManager.LoadScene(0);
    }

    public void StartGame(){
        SceneManager.LoadScene(1);
    }
}
