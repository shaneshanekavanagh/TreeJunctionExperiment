using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisengageParent : MonoBehaviour
{
    public void MakeParentNull()
    {
        transform.parent = null;
    }
}
