using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUDMIDscript : MonoBehaviour {

    public GameObject AnimatingObj;
    public GameObject ParentObj;

    //public GameObject PivotObj;
    // Use this for initialization
    int randomInst;

    void OnEnable ()
    {
        randomInst = Random.Range(0, 4);

        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = true;
        }            
    }

    void InstObj()
    {
        if (randomInst == 1)
        {
            GameObject objF = ObjectPoolingManager.current.GetPooledFlower();
            if (objF == null) return;
            objF.transform.position = ParentObj.transform.position;
            objF.transform.rotation = ParentObj.transform.rotation;
            objF.SetActive(true);

            objF.transform.parent = ParentObj.transform.parent;

            objF.GetComponent<OriginObj>().InstantiatedFrom = transform.parent.GetComponent<OriginObj>().InstantiatedFrom;
        }
        else
        {
            GameObject objL = ObjectPoolingManager.current.GetPooledLeaf();
            if (objL == null) return;
            objL.transform.position = ParentObj.transform.position;
            objL.transform.rotation = ParentObj.transform.rotation;
            objL.SetActive(true);

            objL.transform.parent = ParentObj.transform.parent;

            objL.GetComponent<OriginObj>().InstantiatedFrom = transform.parent.GetComponent<OriginObj>().InstantiatedFrom;
        }
    }
    
    void Death()
    {
        ParentObj.GetComponent<KillOffScript>().DeathRattle();
        /*foreach (Transform child in transform)
        {
            var script = child.gameObject.GetComponent<KillOffScript>();
            if (script != null)
            {
                script.DeathRattle();
            }
        }*/
    }

    public void GotHit()
    {
        InstObj();

        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = false;
        }

        AnimatingObj.GetComponent<BudAnimate>().PlayBite();

        Invoke("Death", 3.0f);
        
        //StartAnimation
        //leaf or flower added
        //start animation for this and the flower or leaf
        //when animation is done, remove this
        //activate the leaf or flower colliders
    }
}
