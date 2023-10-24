using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListControl : MonoBehaviour
{
    public GameObject StartTree;
    //public GameObject StartJunc;
    //public GameObject StartBud;

    public List<GameObject> ScaleableObjs = new List<GameObject>();
    public List<GameObject> NonScaleableObjs = new List<GameObject>();
    public List<GameObject> WiltableObjs = new List<GameObject>();

    public List<GameObject> ExtObjs = new List<GameObject>();

    public List<GameObject> DistanceCheckList = new List<GameObject>();

    Vector3 LScale = new Vector3(0.01f, 0.01f, 0.01f);
    Vector3 TScale = new Vector3(0.01f, 0, 0.01f);

    IEnumerator DistIEnum;
    //void Start()
    //{
    //ScaleableObjs.Add(StartTree);
    //AllObjs.Add(StartBud);
    //ScaleableObjs.Add(StartJunc);
    //}

    IEnumerator DistanceCheckerIE()
    {
        for (int i = 0; i < DistanceCheckList.Count; i++)
        {
            if ((DistanceCheckList[i] == null) || (DistanceCheckList[i] != isActiveAndEnabled))
            {
                DistanceCheckList.Remove(DistanceCheckList[i]);
                yield return null;
                StopDistanceCheck();
                break;

            }
            else
            {
                for(int e = 0; e < ExtObjs.Count; e++)
                {
                    if(ExtObjs[e] == null || ExtObjs[e] != isActiveAndEnabled)
                    {
                        ExtObjs.Remove(ExtObjs[e]);
                    }
                    else if((Vector3.Distance(DistanceCheckList[i].transform.position, ExtObjs[e].transform.position))<0.025)
                    {
                        TryAgain(DistanceCheckList[i].gameObject, null);
                        yield return null;
                        StopDistanceCheck();
                        break;
                    }
                }
                yield return null;

                for (int t = 0; t < DistanceCheckList.Count; t++)
                {
                    //if(DistanceCheckList[i] == null || DistanceCheckList[t] == null)
                    if((DistanceCheckList[t] == null) || (DistanceCheckList[t] != isActiveAndEnabled))
                    {
                        yield return null;
                        StopDistanceCheck();
                        break;
                    }
                    else if ((DistanceCheckList[i]) == (DistanceCheckList[t]))
                    {
                        yield return null;
                        StopDistanceCheck();
                        //Debug.Log("it's the same");
                        break;
                    }
                    //else { Debug.Log("this close " + Vector3.Distance(DistanceCheckList[i].transform.position, DistanceCheckList[t].transform.position)); }
                    else if (Vector3.Distance(DistanceCheckList[i].transform.position, DistanceCheckList[t].transform.position) < 0.025)
                    {
                        TryAgain(DistanceCheckList[i].gameObject,DistanceCheckList[t].gameObject);

                        //DistanceCheckList[t].GetComponent<ObjRotValue>().GotHit();
                        //yield return null;
                        //DistanceCheckList[t].transform.GetChild(1).GetComponent<ObjRotValue>().GotHit();
                        //Debug.Log("this close " + Vector3.Distance(DistanceCheckList[i].transform.position, DistanceCheckList[t].transform.position));
                        //DistanceCheckList[i].transform.parent.GetComponent<KillOffScript>().InstantDeath();

                        //DistanceCheckList.Remove(DistanceCheckList[i]);
                        yield return null;
                        StopDistanceCheck();
                        break;
                    }
                    else
                    {

                    }
                }
                yield return null;
            }
            yield return null;
        }
        yield return null;
        StopDistanceCheck();
    }

    void TryAgain(GameObject closeOne, GameObject keptOne)
    {
        if (keptOne == null)
        {
            Debug.Log("this is null");
        }
        else
        {
            keptOne.transform.parent.GetChild(1).GetComponent<ObjRotValue>().GotHit();
        }
        closeOne.transform.parent.GetComponent<KillOffScript>().InstantDeath();

        DistanceCheckList.Remove(closeOne);
    }

    void StopDistanceCheck()
    {
        StopCoroutine(DistIEnum);
    }

    public void ScaleAll()
    {
        StartTree.transform.localScale = StartTree.transform.localScale + TScale;
        for (int i = 0; i < ScaleableObjs.Count; i++)
        {
            if ((ScaleableObjs[i] == null) || (ScaleableObjs[i] != isActiveAndEnabled))
            {
                ScaleableObjs.Remove(ScaleableObjs[i]);
            }
            else
            {
               // if (ScaleableObjs[i].gameObject.tag == "juncObj")
                //{
                   // ScaleableObjs[i].transform.localScale = ScaleableObjs[i].transform.localScale - LScale;
               // }
               // else
               // {
                ScaleableObjs[i].transform.localScale = ScaleableObjs[i].transform.localScale + LScale;
                ScaleableObjs[i].GetComponent<UpdatePosWithScale>().UpdateThePosition();
                //StartTree.GetComponent<TreeStartScript>().ScaleTree();
                // }
            }
        }
        for (int i = 0; i < NonScaleableObjs.Count; i++)
        {
            if ((NonScaleableObjs[i] == null) || (NonScaleableObjs[i] != isActiveAndEnabled))
            {
                NonScaleableObjs.Remove(NonScaleableObjs[i]);
            }
            else
            {
                // if (ScaleableObjs[i].gameObject.tag == "juncObj")
                //{
                // ScaleableObjs[i].transform.localScale = ScaleableObjs[i].transform.localScale - LScale;
                // }
                // else
                // {
                //NonScaleableObjs[i].transform.localScale = NonScaleableObjs[i].transform.localScale + LScale;
                NonScaleableObjs[i].GetComponent<UpdatePosWithScale>().UpdateThePosition();
                //StartTree.GetComponent<TreeStartScript>().ScaleTree();
                // }
            }
        }
        if (DistIEnum != null)
        {
            StopCoroutine(DistIEnum);
        }

        DistIEnum = DistanceCheckerIE();
        StartCoroutine(DistIEnum);
    }
}
