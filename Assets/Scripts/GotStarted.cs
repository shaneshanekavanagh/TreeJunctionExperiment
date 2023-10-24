using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotStarted : MonoBehaviour
{
    public GameObject HoriPos;
    public GameObject VertPos;
    public GameObject CamZoom;
    public GameObject RayCaster;

    //GameObject TempFader;
    public GameObject FadeText;
    public GameObject FadeText2;

    public GameObject fadeGuiImage;

    bool built = false;
    bool pressed = false;

    private void Start()
    {
        //TempFader = FadeManager.Instance.gameObject;
        //TempFader.GetComponent<FadeManager>().Fade(false, 1.25f);
    }
    public void Started()
    {
        built = true;
        FadeText.SetActive(false);
        FadeText2.SetActive(true);
    }

    void StartedPressed()
    { 
        HoriPos.GetComponent<HoriPivotCs>().Started = true;
        VertPos.GetComponent<VertPivotCs>().Started = true;
        CamZoom.GetComponent<CamZoomMast>().Started = true;
        RayCaster.GetComponent<rayCastManager>().Started = true;

        
        //TempFader.GetComponent<FadeManager>().Fade(true, 1.25f);

        

        Invoke("RemoveThis", 1.30f);
        FadeText2.SetActive(false);
        fadeGuiImage.SetActive(false);
    }

    void RemoveThis()
    {
        //TempFader.GetComponent<FadeManager>().Fade(false, 1.25f);
        DoneNow();
        //Invoke("DoneNow", 1.30f);
    }
    void DoneNow()
    {
        this.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (built && !pressed)
        {
            if (Input.GetMouseButton(0))
            {
                StartedPressed();
                pressed = true;
            }
        }
    }

}
