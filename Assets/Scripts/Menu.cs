using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Continue()
    {

    }

    public void BackToMain()
    {
        SceneManager.LoadScene("StartScene");
    }
}
