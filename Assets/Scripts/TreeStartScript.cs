using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStartScript : MonoBehaviour
{
    public GameObject ListController;
    public Transform firstBudLoc;
    public GameObject NodeObj;

    void Start()
    {
        InstFirstBud();
    }

    void InstFirstBud()
    {
        ListController.GetComponent<ListControl>().ScaleableObjs.Add(NodeObj);
        NodeObj.GetComponent<UpdatePosWithScale>().origPos = firstBudLoc.transform;

        GameObject objJ16 = ObjectPoolingManager.current.GetPooledJunc16();
        if (objJ16 == null) return;

        ObjInstantiated(objJ16);
    }

    void ObjInstantiated(GameObject InstObject)
    {
        InstObject.transform.position = NodeObj.transform.position;
        InstObject.transform.rotation = NodeObj.transform.rotation;
        InstObject.SetActive(true);

        if (!ListController.GetComponent<ListControl>().NonScaleableObjs.Contains(InstObject))
        {
            ListController.GetComponent<ListControl>().NonScaleableObjs.Add(InstObject);
        }
        //InstObject.transform.parent = transform;
    }

    //public void ScaleTree()
   // {
    //    transform.localScale = transform.localScale + new Vector3(0.002f, 0, 0.002f);
    //} 
}
