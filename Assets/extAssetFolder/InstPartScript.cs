using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPartScript : MonoBehaviour
{
    public Transform InstObjLoc;
    private void OnEnable()
    {
        GameObject objWP = ObjectPoolingManager.current.GetPooledWoodParts();
        if (objWP == null) return;
        objWP.transform.position = InstObjLoc.position;
        objWP.transform.rotation = InstObjLoc.rotation;
        objWP.SetActive(true);                
    }
}
