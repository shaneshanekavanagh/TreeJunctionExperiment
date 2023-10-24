using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePosWithScale : MonoBehaviour
{
    public Transform origPos;

    public void UpdateThePosition()
    {
        if(origPos != null)
        {
            transform.position = origPos.position;
        }
        else
        {
            //Debug.Log("it's null");
        }
    }
}
