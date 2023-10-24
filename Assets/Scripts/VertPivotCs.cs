using UnityEngine;
using System.Collections;

public class VertPivotCs : MonoBehaviour
{
    public bool Started = false;
    public float cameraTopLimit;
    public float cameraBottomLimit;

    // Position period that the camera won't rotate
    public float thresholdTop;
    public float thresholdBottom;

    // variables to define the camera movement speed, camera rotation speed, and deceleration(lerp) speed respectively
    public float moveSpeed;
    public float rotationSpeed;
    public float lerpSpeed;

    // hold timer to prevent the camera from jerking in mobile device
    private float holdTimer = 0.0f;

    // holds the y-axis retrieved from mouse
    private float yaxis;

    // holds the current 
    private float speed;

    public float minimumTilt = -30F;
    public float maximumTilt = 30F;
    private float rotationY = 0F;
    private Quaternion originalRotation;
    
    // Use this for initialization
    void Start()
    {
        originalRotation = transform.localRotation;
    }
    // function to clamp the angle based on given min and max
    static float ClampAngle(float angle, float min, float max)
    {
        //if (masterClientBool == true)
        // {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);

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

                // if the user hold for more than 3 frame, record the mouse y-axis
                if (Input.GetMouseButton(0) && holdTimer > 3)
                {
                    // reverse the received y-axis to create inverse-axis movement (remove minus sign if you want normal-axis movement)
                    yaxis = -Input.GetAxis("Mouse Y");
                    speed = yaxis;
                }
                // else the user is not holding the mouse click anymore, begin calculating the lerp speed 
                else
                {
                    var ix = Time.deltaTime * lerpSpeed;
                    speed = Mathf.Lerp(speed, 0, ix);
                }

                // if the user release the mouse/touch, reset the timer
                if (Input.GetMouseButtonUp(0))
                {
                    holdTimer = 0;
                }

                // calculate the movement of the camera, clamp it so that it won't exceed the limit
                var limitY = Mathf.Clamp(transform.position.y + (speed * moveSpeed), cameraBottomLimit, cameraTopLimit);
                transform.position = new Vector3(transform.position.x, limitY, transform.position.z);



                // if the camera pos still inside the limit, rotate the camera as well
                if (!(transform.position.y < thresholdTop && transform.position.y > thresholdBottom))
                {
                    rotationY += speed * -rotationSpeed;
                    //Debug.Log("Rotation Y: " + rotationY);
                    rotationY = ClampAngle(rotationY, -maximumTilt, -minimumTilt);
                    Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, Vector3.left);
                    transform.localRotation = originalRotation * yQuaternion;
                }

            }
        }
    }
}

