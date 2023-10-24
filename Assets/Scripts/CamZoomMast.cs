using UnityEngine;
using System.Collections;

public class CamZoomMast : MonoBehaviour
{
    public bool Started = false;
    float fovMax = 150f;
    float fovMin = 0.5f;
    public float camFOV;
    float camFovOrg;
   
    Rect sliderPos = new Rect(20, 300, 50, 150);

    public float perspectiveZoomSpeed = 0.5f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.5f;        // The rate of change of the orthographic size in orthographic mode.
    // public bool toggleVisBool = false;	

    void Start()
    {
        camFOV = 50.0f;
        camFovOrg = camFOV;
    }


    void Update()
    {
        if (Started)
        {
            if (camFOV > fovMin)
            {
                if (Input.GetAxis("Mouse ScrollWheel") > 0)
                {
                    camFOV = camFOV - 4;
                }
            }

            if (camFOV < fovMax)
            {
                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                    camFOV = camFOV + 4;
                }
            }

            
            // If there are two touches on the device...
            if (Input.touchCount == 2)
            {
                // Store both touches.
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                // Find the position in the previous frame of each touch.
                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                // Find the magnitude of the vector (the distance) between the touches in each frame.
                float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

                // Find the difference in the distances between each frame.
                float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;


                if ((camFOV < fovMax) && (camFOV > fovMin))
                {
                    camFOV += deltaMagnitudeDiff * perspectiveZoomSpeed;

                   
                }
                // Otherwise change the field of view based on the change in distance between the touches.
                //GetComponent<Camera>().fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

                // Clamp the field of view to make sure it's between 0 and 180.
                //GetComponent<Camera>().fieldOfView = Mathf.Clamp(GetComponent<Camera>().fieldOfView, 0.1f, 179.9f);

            }
        }
        if(camFOV > fovMax)
        {
            camFOV = fovMax - 1.0f;
        }
        if(camFOV < fovMin)
        {
            camFOV = fovMin + 1;
        }
    }


    void OnGUI()
    {
        camFOV = GUI.VerticalSlider(sliderPos, camFOV, fovMin, fovMax);
    }


}