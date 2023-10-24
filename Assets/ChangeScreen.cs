using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    public void GofullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void LoadSceneNow(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

}
