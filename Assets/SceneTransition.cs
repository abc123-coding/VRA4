using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void Update()
    {
        if(Time.timeScale != 0.0f && Input.GetButtonDown("Fire1") && !CheckSingleton.cloth && SceneManager.GetActiveScene().name == "GameScene")
        {
            ChangeScene("Clothing");
            CheckSingleton.cloth = true;
        }
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}