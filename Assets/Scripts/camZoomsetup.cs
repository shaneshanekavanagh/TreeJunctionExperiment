using UnityEngine;
using System.Collections;

public class camZoomsetup : MonoBehaviour
{


    float camFOV;

    //GameObject camZoom;
    GameObject GuiObj;
    void Start()
    {

        //camZoom = GameObject.FindGameObjectWithTag("camZoomMast");
    }


    void Update()
    {

        //if (GuiObj != null)
        //{

        camFOV = GetComponent<CamZoomMast>().camFOV;

        if (!Mathf.Approximately(camFOV, GetComponent<Camera>().fieldOfView))
        {
            GetComponent<Camera>().fieldOfView = camFOV;

        }


    }

}
