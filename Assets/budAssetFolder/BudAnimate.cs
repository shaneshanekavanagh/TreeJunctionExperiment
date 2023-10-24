using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudAnimate : MonoBehaviour
{
    float animateSpeed;

    public string anim1 = "idleClosed";
    public string anim2 = "open";
    
    void OnEnable()
    {
        animateSpeed = 0.0f;
        GetComponent<Animation>()[anim1].speed = 0.0f;
        GetComponent<Animation>().Play(anim1);
    }

    public void PlayBite()
    {
        GetComponent<Animation>()[anim2].speed = 1.0f;
        GetComponent<Animation>().Play(anim2);
    }
    void OnDisable()
    {

    }
}
