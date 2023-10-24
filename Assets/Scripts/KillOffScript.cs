using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOffScript : MonoBehaviour
{
    public void DeathRattle()
    {
        Invoke("Death", 0.1f);
    }

    public void InstantDeath()
    {
        Death();
    }

    void Death()
    { 
        transform.parent = null;
        transform.localScale = new Vector3(1,1,1);
        gameObject.SetActive(false);
    }
}
