using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneWaitTillReady : MonoBehaviour
{
    public GameObject MainButton;

    void Start()
    {
        Invoke("ReadyNow", 1.0f);
    }

    void ReadyNow()
    {
        MainButton.SetActive(true);
    }
}
