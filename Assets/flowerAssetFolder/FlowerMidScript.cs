using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMidScript : MonoBehaviour {

    public GameObject AnimatingObj;
    public GameObject ParentObj;

    GameObject OrigPos;

    void OnEnable ()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = false;
        }
        Invoke("StartedUp", 0.1f);
    }

    void StartedUp()
    {
        AnimatingObj.GetComponent<FlowerAnimationScript>().PlayBite();
        Invoke("StartObjCollider", 3.0f);
    }

    void StartObjCollider()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = true;
        }
    }
	
    void Death()
    {
        ParentObj.GetComponent<OriginObj>().InstantiatedFrom.GetComponent<ObjRotValue>().InstBud();
        ParentObj.GetComponent<KillOffScript>().DeathRattle();
    }

    public void GotHit()
    {
        Debug.Log("this flower is wilting");
        Invoke("Death", 1.0f);
    }

    void OnDisable()
    {
        
    }
}
