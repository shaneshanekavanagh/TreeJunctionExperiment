using UnityEngine;
using System.Collections;

public class HoriPivotCs : MonoBehaviour {
   

public float rotationSpeed;

    public bool Started = false;
// variable that determine the speed of lerping (deceleration)
public float lerpSpeed;

// variable that holds the current rotation speed
private float speed;

// timer to check whether the touch is a valid rotation, to prevent camera jerking on mobile device
private float holdTimer = 0.0f;

// variable to hold the x-axis from mouse
private float xAxis = 0.0f;
    //public var guiObj: GameObject;

    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount <= 1)
        {
            if (Started)
            {
                if (Input.GetMouseButton(0))
                {
                    holdTimer++;
                }

                // if the user hold for more than 3 frame, record the mouse x-axis
                if (Input.GetMouseButton(0) && holdTimer > 3)
                {
                    holdTimer++;
                    xAxis = Input.GetAxis("Mouse X");
                    speed = xAxis;
                }
                // else the user is not holding the mouse click anymore, begin calculating the lerp speed 
                else
                {
                    var i = Time.deltaTime * lerpSpeed;
                    speed = Mathf.Lerp(speed, 0, i);
                }

                // if the user release the mouse/touch, reset the timer
                if (Input.GetMouseButtonUp(0))
                {
                    holdTimer = 0;
                }

                // rotate the object
                transform.Rotate(0.0f, speed * rotationSpeed, 0.0f, Space.World);

            }
        }
    }
}

