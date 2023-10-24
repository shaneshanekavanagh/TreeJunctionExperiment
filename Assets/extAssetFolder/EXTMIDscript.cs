using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXTMIDscript : MonoBehaviour {

    public GameObject ParentObj;
    public Transform InstPivotObj;
    //public Transform AnimatedPivotObj;

    void OnEnable()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    void Death()
    {
        ParentObj.GetComponent<KillOffScript>().DeathRattle();
        foreach (Transform child in transform)
        {
            var script = child.gameObject.GetComponent<KillOffScript>();
            if (script != null)
            {
                script.DeathRattle();
            }
        }
    }

    public void GotHit()
    {
       // foreach (Transform child in transform)
       // {
       //     child.gameObject.GetComponent<Collider>().enabled = false;
       // }
       // Death();
    }
}
