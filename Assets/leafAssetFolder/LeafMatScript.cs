using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMatScript : MonoBehaviour
{
    public Color Color1, Color2, Color3;
    public float Speed = 1, Offset;

    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;

    bool greenBool;
    bool yellowBool;
    bool redBool;
    bool changingColour;

    Color CurrentColour;

    IEnumerator ChangeMatTemp;

    float StopTimer = 0;

    private void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
        _renderer = GetComponent<Renderer>();       
    }

    void OnEnable()
    {
        StartAndSet();
    }

    public void StartAndSet()
    {
        changingColour = false;
        greenBool = true; 
        yellowBool = false; 
        redBool = false;

        StopTimer = 0;

        _propBlock = new MaterialPropertyBlock();
        _renderer = GetComponent<Renderer>();

        _propBlock.SetColor("_Color", Color1);
        _renderer.SetPropertyBlock(_propBlock);
    }

    public void ChangeMatTrigger(GameObject trigObj)
    {
        //CurrentColour = 
        //_propBlock.GetColor("_Color");
        //GetComponent<Renderer>().material.color;
        if (changingColour == false)
        {
            StopTimer = 0;
            if (ChangeMatTemp != null)
            {
                StopCoroutine(ChangeMatTemp);
            }

            if (greenBool)
            {
                ChangeMatTemp = ChangeGreenToYellow();
            }
            else if (yellowBool)
            {
                ChangeMatTemp = ChangeYellowToRed();
            }
            else if (redBool)
            {
                trigObj.GetComponent<LeafMidScript>().Death();
            }
            StartCoroutine(ChangeMatTemp);
            changingColour = true;
        }
    }

    IEnumerator ChangeGreenToYellow()
    {
        //while(_propBlock.GetColor("_Color") != Color2)
        while(StopTimer < 0.99)
        {
            StopTimer = StopTimer + Time.deltaTime;
                //(Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f;
            //Debug.Log((Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f);
            // Get the current value of the material properties in the renderer.
            _renderer.GetPropertyBlock(_propBlock);

            // Assign our new value.
            //_propBlock.SetColor("_Color", Color.Lerp(Color1, Color2, (Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f));
            _propBlock.SetColor("_Color", Color.Lerp(Color1, Color2, StopTimer));
            // Apply the edited values to the renderer.
            _renderer.SetPropertyBlock(_propBlock);

            yield return null;
        }

        yield return null;
        greenBool = false;
        yellowBool = true;
        redBool = false;
        changingColour = false;
    }

    IEnumerator ChangeYellowToRed()
    {
        //while(_propBlock.GetColor("_Color") != Color2)
        while (StopTimer < 0.99)
        {
            StopTimer = StopTimer + Time.deltaTime;
            //(Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f;
            //Debug.Log((Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f);
            // Get the current value of the material properties in the renderer.
            _renderer.GetPropertyBlock(_propBlock);

            // Assign our new value.
            //_propBlock.SetColor("_Color", Color.Lerp(Color1, Color2, (Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f));
            _propBlock.SetColor("_Color", Color.Lerp(Color2, Color3, StopTimer));
            // Apply the edited values to the renderer.
            _renderer.SetPropertyBlock(_propBlock);

            yield return null;
        }

        yield return null;
        greenBool = false;
        yellowBool = false;
        redBool = true;
        changingColour = false;
    }

    /* void Update()
     {

         // Get the current value of the material properties in the renderer.
         _renderer.GetPropertyBlock(_propBlock);

         // Assign our new value.
         _propBlock.SetColor("_Color", Color.Lerp(Color1, Color2, (Mathf.Sin(Time.time * Speed + Offset) + 1) / 2f));

         // Apply the edited values to the renderer.
         _renderer.SetPropertyBlock(_propBlock);

     }*/
}
