using UnityEngine;
using System.Collections;
 
public class horipos : MonoBehaviour
{
    Vector3 correctPlayerPos;
    Quaternion correctPlayerRot;

    Vector3 updatedPos;
    Quaternion updatedRot;

    float angle = 0.0f;
    float dist = 0.0f;

	void Start() 
    {       
        updatedPos = transform.position;
        updatedRot = transform.rotation;
        
        correctPlayerPos = transform.position;
        correctPlayerRot = transform.rotation;
	}

    void Update()
    {
    }

}