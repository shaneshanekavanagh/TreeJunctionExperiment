using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodPartScript : MonoBehaviour
{
    AudioSource woodPartSound;

    private void OnEnable()
    {
        woodPartSound = GetComponent<AudioSource>();
        woodPartSound.Play();
    }
    
}
