using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastManager : MonoBehaviour {

    LayerMask plantObjLayerMask;
    
    public float TouFloat;
    public bool TouBool;
    public string currentObj = "";

    string oldObj;

    GameObject oldParObj;
    public GameObject touchParticle;
    string deBugg;

    float zeroFl = 0.0f;
    float firstFl = 0.7f;
    float secondFl = 1.99f;
    public bool Started = false;

	void Start ()
    {
        TouFloat = 0.0f;
        TouBool = false;

        plantObjLayerMask = LayerMask.GetMask("plantObjLayer");
    }

    void RayHit(string newObj,GameObject parObj)
    {
        if((newObj == oldObj)&&(parObj == oldParObj))
        {

        }
        else
        {
            TouFloat = 0.0f;
            oldObj = newObj;
            oldParObj = parObj;
        }
    }

    void Update()
    {
        if (Started)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000, plantObjLayerMask))
            {

                touchParticle.transform.position = hit.point;

                Debug.DrawRay(hit.point, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);



                if (hit.collider.gameObject.tag == "exThitMid")
                {
                    currentObj = hit.collider.gameObject.tag;
                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            //deBugg = "Soldify called on" + hit.collider.tag;
                        }
                        else if (TouFloat >= secondFl)
                        {
                            //deBugg = "Decay called on" + hit.collider.tag;
                            hit.collider.gameObject.transform.parent.GetComponent<EXTMIDscript>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                        }

                        //hit.collider.gameObject.transform.parent.GetComponent<EXTMIDscript>().GotHit();
                        RayHit(hit.collider.transform.parent.gameObject.tag, hit.collider.transform.parent.parent.gameObject);
                    }
                }
                /*else if (hit.collider.gameObject.tag == "exThitBot")
                {
                    TouBool = true;
                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            deBugg = "Ext/Split called on" + hit.collider.tag;
                        }


                        hit.collider.gameObject.transform.parent.GetComponent<EXTMIDscript>().GotHit();
                        RayHit(hit.collider.transform.parent.gameObject.tag, hit.collider.transform.parent.parent.gameObject);
                    }
                }*/
                else if (hit.collider.gameObject.tag == "buDhitMid")
                {
                    currentObj = hit.collider.gameObject.tag;

                    TouBool = true;
                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            //deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            hit.collider.transform.parent.gameObject.GetComponent<BUDMIDscript>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                            //deBugg = "Leaf/Flow called on" + hit.collider.tag;
                        }


                        //hit.collider.transform.parent.gameObject.GetComponent<BUDMIDscript>().GotHit();
                        RayHit(hit.collider.transform.parent.gameObject.tag, hit.collider.transform.parent.parent.gameObject);
                    }
                }
                /*else if (hit.collider.gameObject.tag == "buDhitBot")
                {
                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            deBugg = "Ext/Split called on" + hit.collider.tag;
                        }


                        hit.collider.gameObject.GetComponent<BUDBOTscript>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }*/
                else if (hit.collider.gameObject.tag == "flOhitMid")
                {
                    currentObj = hit.collider.gameObject.tag;

                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            //deBugg = "Bloom called on" + hit.collider.tag;
                        }
                        else if (TouFloat >= secondFl)
                        {
                            hit.collider.gameObject.transform.parent.GetComponent<FlowerMidScript>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                            //deBugg = "Wilt called on" + hit.collider.tag;
                        }

                        //hit.collider.gameObject.transform.parent.GetComponent<FlowerMidScript>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }
                /*else if (hit.collider.gameObject.tag == "flOhitBot")
                {
                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            deBugg = "Ext/Split called on" + hit.collider.tag;
                        }

                        hit.collider.gameObject.GetComponent<FlowerBotScript>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }*/
                else if (hit.collider.gameObject.tag == "leAhitMid")
                {
                    currentObj = hit.collider.gameObject.tag;

                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            hit.collider.gameObject.transform.parent.GetComponent<LeafMidScript>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                            //deBugg = "GrowLeaf called on" + hit.collider.tag;
                        }
                        else if (TouFloat >= secondFl)
                        {
                            /*hit.collider.gameObject.transform.parent.GetComponent<LeafMidScript>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                            //deBugg = "Crispy called on" + hit.collider.tag;
                            */
                        }

                        //hit.collider.gameObject.transform.parent.GetComponent<LeafMidScript>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }
                /*else if (hit.collider.gameObject.tag == "leAhitBot")
                {
                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            deBugg = "Ext/Split called on" + hit.collider.tag;
                        }

                        hit.collider.gameObject.GetComponent<LeafBotScript>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }*/
                else if (hit.collider.gameObject.tag == "junCHitObj")
                {
                    currentObj = hit.collider.gameObject.tag;

                    TouBool = true;

                    if (Input.GetMouseButton(0))
                    {
                        TouFloat += 1f * Time.deltaTime;
                        TouFloat = Mathf.Clamp(TouFloat, 0.0f, 2.0f);

                        if ((TouFloat > zeroFl) && (TouFloat < firstFl))
                        {
                            deBugg = "Selected " + hit.collider.tag;
                        }
                        else if ((TouFloat > firstFl) && (TouFloat < secondFl))
                        {
                            hit.collider.gameObject.GetComponent<ObjRotValue>().GotHit();
                            TouBool = false;
                            TouFloat = 0.0f;
                            //deBugg = "Ext/Split called on" + hit.collider.tag;
                        }
                        //Debug.Log("hithere");
                        //hit.collider.gameObject.GetComponent<ObjRotValue>().GotHit();
                        RayHit(hit.collider.gameObject.tag, hit.collider.transform.parent.gameObject);
                    }
                }
                //else if (hit.collider.gameObject.tag == "NotHittingGoodStuff")
                else if (hit.collider.gameObject == null)
                {
                    TouBool = false;
                    TouFloat = 0.0f;

                    currentObj = "null";
                }
                //hit leaf
                //hit flower
            }


            if (Input.GetMouseButtonUp(0))
            {
                TouBool = false;
                TouFloat = 0.0f;
            }

            touchParticle.GetComponent<ParticleSystem>().startSize = (TouFloat * 0.1f);
        }
    }

    /*void OnGUI()
    {
        if (TouBool == true)
        {
            GUI.Label(new Rect(100, 100, 400, 400), "" + TouFloat);
            GUI.Label(new Rect(100, 125, 400, 400), "" + deBugg);
            GUI.Label(new Rect(100, 150, 400, 400), "" + TouBool);
            GUI.Label(new Rect(100, 175, 400, 400), currentObj);
        }
    }*/
}
