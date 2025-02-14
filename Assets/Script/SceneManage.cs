using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadNewScene()
    {
        SceneManager.LoadScene("NewScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
