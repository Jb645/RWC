using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SceneChanger()
    {
        SceneManager.LoadScene(0);
    }

    public void SceneChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}