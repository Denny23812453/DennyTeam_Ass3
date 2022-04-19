using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RePlay : MonoBehaviour {


    public void ChangeScene()
    {
        Invoke("MyScene", 0.5f);
    }

    public void MyScene()
    {
        SceneManager.LoadScene("ZiWangGame");

    }

    public void QuitGame()
    {
        Invoke("ExitGame", 0.5f);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
