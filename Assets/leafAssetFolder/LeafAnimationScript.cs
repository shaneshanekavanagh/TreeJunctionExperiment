using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafAnimationScript : MonoBehaviour {

    float animateSpeed;

    public string anim1 = "closed";
    public string anim2 = "open";
    public string anim3 = "opened";

    IEnumerator SlowAnimTemp;

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

    public void PlayWobble()
    {
        GetComponent<Animation>()[anim3].speed = 1.0f;
        GetComponent<Animation>().Play(anim3);
    }

    public void StopWobble()
    {
        if(SlowAnimTemp != null)
        {
            StopCoroutine(SlowAnimTemp);
        }
        SlowAnimTemp = SlowAnim(anim3,1.0f);
        StartCoroutine(SlowAnimTemp);
    }

    IEnumerator SlowAnim(string num, float tempFloat)
    {
        while (tempFloat > 0.0f)
        {
            tempFloat -= Time.deltaTime/2;
            if (tempFloat > 0.0f)
            {
                GetComponent<Animation>()[num].speed = tempFloat;
            }
            yield return null;            
        }
        yield return null;
        
        StopSlowAnim();
        GetComponent<Animation>().Stop(num);
    }

    void StopSlowAnim()
    {
        StopCoroutine(SlowAnimTemp);        
    }

    void OnDisable()
    {
       
    }
}
