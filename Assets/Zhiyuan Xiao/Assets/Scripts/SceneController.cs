using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour {


    public void ChangeScene()
    {
        Invoke("MyScene", 0.5f);
    }

    public void MyScene()
    {
        SceneManager.LoadScene("ZhiyuanXiaoGame");

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
