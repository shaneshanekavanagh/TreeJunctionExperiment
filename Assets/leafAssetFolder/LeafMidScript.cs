using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMidScript : MonoBehaviour {
    public GameObject AnimatingObj;
    public GameObject ParentObj;
    public GameObject LeafModel;

    IEnumerator stillChanging;

    bool notChanging;

    void OnEnable()
    {
        notChanging = true;

        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = false;
        }
        Invoke("StartedUp", 0.1f);
    }

    void StartedUp()
    {
        AnimatingObj.GetComponent<LeafAnimationScript>().PlayBite();
        Invoke("StartObjCollider", 3.0f);
    }

    void StartObjCollider()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    public void Death()
    {
        ParentObj.GetComponent<OriginObj>().InstantiatedFrom.GetComponent<ObjRotValue>().InstBud();
        ParentObj.GetComponent<KillOffScript>().DeathRattle();
    }

    IEnumerator ChangingTime()
    {
        notChanging = false;
        yield return new WaitForSeconds(1.0f);
        notChanging = true;
        yield return new WaitForSeconds(3.0f);
        AnimatingObj.GetComponent<LeafAnimationScript>().StopWobble();
    }

    public void GotHit()
    {
        if (notChanging)
        {
            LeafModel.GetComponent<LeafMatScript>().ChangeMatTrigger(this.gameObject);
            AnimatingObj.GetComponent<LeafAnimationScript>().PlayWobble();
            Debug.Log("this leaf is wilting");
            //Invoke("Death", 1.0f);

            if (stillChanging != null)
            {
                StopCoroutine(stillChanging);
            }
            stillChanging = ChangingTime();
            StartCoroutine(stillChanging);
        }
    }

    void OnDisable()
    {

    }
}
