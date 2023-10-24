using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotValue : MonoBehaviour
{
    public int rotValue;
    int thisRot;
    public int AcceptableExtInst = 17;
    public int AcceptableJuncInst = 17;

    GameObject ListController;
    //List<GameObject> AllObjList; 
    IEnumerator randJunc;
    IEnumerator randExt;
    IEnumerator posWhileAnimated;

    public Transform InstPos;
    public Transform ParentObj;

    GameObject NodeParObj;
    Transform NewPos;
    Transform OrigParTran;
    //int randomInst;

    //int extCount;
    //bool juncBool;

    bool budBool;
    bool extBool;

    void OnEnable()
    {
        budBool = false;
        extBool = false;

        //juncBool = false;
        //extCount = 0;
        thisRot = rotValue;

        RunRandJUNC();
        RunRandEXT();

        //randomInst = Random.Range(0, 3);

        //InstStart();
        //InstBud();

        ListController = GameObject.FindWithTag("managerList");

        // AllObjList = ListController.GetComponent<ListControl>().AllObjs;
        NodeParObj = GameObject.FindWithTag("nodeObj");
    }

    /*
    void InstStart()
    {
        if (transform.GetChild(0).gameObject.tag == "juncInstPos")
        {
            InstPos = transform.GetChild(0);
        }
        else
        {
            foreach (Transform child in transform)
            {
                if (child.tag == "juncInstPos")
                    InstPos = child;
            }
        }
        //InstObj();
        InstBud();
    }
    */


    public void InstBud()
    {
        OrigParTran = ParentObj.transform;

        GameObject objB = ObjectPoolingManager.current.GetPooledBud();
        if (objB == null) return;
        objB.transform.position = InstPos.position;
        objB.transform.rotation = InstPos.rotation;
        objB.SetActive(true);

        //if (objB.active) { Debug.Log("stillAlive"); }
        objB.transform.parent = transform;

        objB.GetComponent<OriginObj>().InstantiatedFrom = this.gameObject;
        /*if (!ListController.GetComponent<ListControl>().AllObjs.Contains(objB))
        {
            ListController.GetComponent<ListControl>().AllObjs.Add(objB);
        }*/

        //InstStartExtObj();
    }

    //firstExt Spawned
    #region
    void InstStartExtObj()
    {
        switch (rotValue)
        {
            case 0:

                GameObject objE0 = ObjectPoolingManager.current.GetPooledExt0();
                if (objE0 == null) return;

                ExtObjInstantiated(objE0);

                break;
            case 1:

                GameObject objE1 = ObjectPoolingManager.current.GetPooledExt1();
                if (objE1 == null) return;

                ExtObjInstantiated(objE1);

                break;
            case 2:

                GameObject objE2 = ObjectPoolingManager.current.GetPooledExt2();
                if (objE2 == null) return;

                ExtObjInstantiated(objE2);

                break;
            case 3:

                GameObject objE3 = ObjectPoolingManager.current.GetPooledExt3();
                if (objE3 == null) return;

                ExtObjInstantiated(objE3);

                break;
            case 4:

                GameObject objE4 = ObjectPoolingManager.current.GetPooledExt4();
                if (objE4 == null) return;

                ExtObjInstantiated(objE4);

                break;
            case 5:

                GameObject objE5 = ObjectPoolingManager.current.GetPooledExt5();
                if (objE5 == null) return;

                ExtObjInstantiated(objE5);

                break;
            case 6:

                GameObject objE6 = ObjectPoolingManager.current.GetPooledExt6();
                if (objE6 == null) return;

                ExtObjInstantiated(objE6);

                break;
            case 7:

                GameObject objE7 = ObjectPoolingManager.current.GetPooledExt7();
                if (objE7 == null) return;

                ExtObjInstantiated(objE7);

                break;
            case 8:

                GameObject objE8 = ObjectPoolingManager.current.GetPooledExt8();
                if (objE8 == null) return;

                ExtObjInstantiated(objE8);

                break;
            case 9:

                GameObject objE9 = ObjectPoolingManager.current.GetPooledExt9();
                if (objE9 == null) return;

                ExtObjInstantiated(objE9);

                break;
            case 10:

                GameObject objE10 = ObjectPoolingManager.current.GetPooledExt10();
                if (objE10 == null) return;

                ExtObjInstantiated(objE10);

                break;
            case 11:

                GameObject objE11 = ObjectPoolingManager.current.GetPooledExt11();
                if (objE11 == null) return;

                ExtObjInstantiated(objE11);

                break;
            case 12:

                GameObject objE12 = ObjectPoolingManager.current.GetPooledExt12();
                if (objE12 == null) return;

                ExtObjInstantiated(objE12);

                break;
            case 13:

                GameObject objE13 = ObjectPoolingManager.current.GetPooledExt13();
                if (objE13 == null) return;

                ExtObjInstantiated(objE13);

                break;
            case 14:

                GameObject objE14 = ObjectPoolingManager.current.GetPooledExt14();

                if (objE14 == null) return;

                ExtObjInstantiated(objE14);

                break;
            case 15:

                GameObject objE15 = ObjectPoolingManager.current.GetPooledExt15();
                if (objE15 == null) return;

                ExtObjInstantiated(objE15);

                break;
            case 16:

                GameObject objE16 = ObjectPoolingManager.current.GetPooledExt16();
                if (objE16 == null) return;

                ExtObjInstantiated(objE16);

                break;

            default:

                break;
        }
    }
    #endregion

    //instExts InstExtObj()
    #region
    void InstExtObj()
    {
        switch (AcceptableExtInst)
        {
            case 0:

                GameObject objE0 = ObjectPoolingManager.current.GetPooledExt0();
                if (objE0 == null) return;

                ExtObjInstantiated(objE0);

                break;
            case 1:

                GameObject objE1 = ObjectPoolingManager.current.GetPooledExt1();
                if (objE1 == null) return;

                ExtObjInstantiated(objE1);

                break;
            case 2:

                GameObject objE2 = ObjectPoolingManager.current.GetPooledExt2();
                if (objE2 == null) return;

                ExtObjInstantiated(objE2);

                break;
            case 3:

                GameObject objE3 = ObjectPoolingManager.current.GetPooledExt3();
                if (objE3 == null) return;

                ExtObjInstantiated(objE3);

                break;
            case 4:

                GameObject objE4 = ObjectPoolingManager.current.GetPooledExt4();
                if (objE4 == null) return;

                ExtObjInstantiated(objE4);

                break;
            case 5:

                GameObject objE5 = ObjectPoolingManager.current.GetPooledExt5();
                if (objE5 == null) return;

                ExtObjInstantiated(objE5);

                break;
            case 6:

                GameObject objE6 = ObjectPoolingManager.current.GetPooledExt6();
                if (objE6 == null) return;

                ExtObjInstantiated(objE6);

                break;
            case 7:

                GameObject objE7 = ObjectPoolingManager.current.GetPooledExt7();
                if (objE7 == null) return;

                ExtObjInstantiated(objE7);

                break;
            case 8:

                GameObject objE8 = ObjectPoolingManager.current.GetPooledExt8();
                if (objE8 == null) return;

                ExtObjInstantiated(objE8);

                break;
            case 9:

                GameObject objE9 = ObjectPoolingManager.current.GetPooledExt9();
                if (objE9 == null) return;

                ExtObjInstantiated(objE9);

                break;
            case 10:

                GameObject objE10 = ObjectPoolingManager.current.GetPooledExt10();
                if (objE10 == null) return;

                ExtObjInstantiated(objE10);

                break;
            case 11:

                GameObject objE11 = ObjectPoolingManager.current.GetPooledExt11();
                if (objE11 == null) return;

                ExtObjInstantiated(objE11);

                break;
            case 12:

                GameObject objE12 = ObjectPoolingManager.current.GetPooledExt12();
                if (objE12 == null) return;

                ExtObjInstantiated(objE12);

                break;
            case 13:

                GameObject objE13 = ObjectPoolingManager.current.GetPooledExt13();
                if (objE13 == null) return;

                ExtObjInstantiated(objE13);

                break;
            case 14:

                GameObject objE14 = ObjectPoolingManager.current.GetPooledExt14();

                if (objE14 == null) return;

                ExtObjInstantiated(objE14);

                break;
            case 15:

                GameObject objE15 = ObjectPoolingManager.current.GetPooledExt15();
                if (objE15 == null) return;

                ExtObjInstantiated(objE15);

                break;
            case 16:

                GameObject objE16 = ObjectPoolingManager.current.GetPooledExt16();
                if (objE16 == null) return;

                ExtObjInstantiated(objE16);

                break;

            default:

                break;
        }
    }
    #endregion

    //instjuncs InstJuncObj()
    #region
    void InstJuncObj()
    {
        switch (AcceptableJuncInst)
        {
            case 0:

                GameObject objJ0 = ObjectPoolingManager.current.GetPooledJunc0();
                if (objJ0 == null) return;

                JuncObjInstantiated(objJ0);

                break;
            case 1:

                GameObject objJ1 = ObjectPoolingManager.current.GetPooledJunc1();
                if (objJ1 == null) return;

                JuncObjInstantiated(objJ1);

                break;
            case 2:

                GameObject objJ2 = ObjectPoolingManager.current.GetPooledJunc2();
                if (objJ2 == null) return;

                JuncObjInstantiated(objJ2);

                break;
            case 3:

                GameObject objJ3 = ObjectPoolingManager.current.GetPooledJunc3();
                if (objJ3 == null) return;

                JuncObjInstantiated(objJ3);

                break;
            case 4:

                GameObject objJ4 = ObjectPoolingManager.current.GetPooledJunc4();
                if (objJ4 == null) return;

                JuncObjInstantiated(objJ4);

                break;
            case 5:

                GameObject objJ5 = ObjectPoolingManager.current.GetPooledJunc5();
                if (objJ5 == null) return;

                JuncObjInstantiated(objJ5);

                break;
            case 6:

                GameObject objJ6 = ObjectPoolingManager.current.GetPooledJunc6();
                if (objJ6 == null) return;

                JuncObjInstantiated(objJ6);

                break;
            case 7:

                GameObject objJ7 = ObjectPoolingManager.current.GetPooledJunc7();
                if (objJ7 == null) return;

                JuncObjInstantiated(objJ7);

                break;
            case 8:

                GameObject objJ8 = ObjectPoolingManager.current.GetPooledJunc8();
                if (objJ8 == null) return;

                JuncObjInstantiated(objJ8);

                break;
            case 9:

                GameObject objJ9 = ObjectPoolingManager.current.GetPooledJunc9();
                if (objJ9 == null) return;

                JuncObjInstantiated(objJ9);

                break;
            case 10:

                GameObject objJ10 = ObjectPoolingManager.current.GetPooledJunc10();
                if (objJ10 == null) return;

                JuncObjInstantiated(objJ10);

                break;
            case 11:

                GameObject objJ11 = ObjectPoolingManager.current.GetPooledJunc11();
                if (objJ11 == null) return;

                JuncObjInstantiated(objJ11);

                break;
            case 12:

                GameObject objJ12 = ObjectPoolingManager.current.GetPooledJunc12();
                if (objJ12 == null) return;

                JuncObjInstantiated(objJ12);

                break;
            case 13:

                GameObject objJ13 = ObjectPoolingManager.current.GetPooledJunc13();
                if (objJ13 == null) return;

                JuncObjInstantiated(objJ13);

                break;
            case 14:

                GameObject objJ14 = ObjectPoolingManager.current.GetPooledJunc14();

                if (objJ14 == null) return;

                JuncObjInstantiated(objJ14);

                break;
            case 15:

                GameObject objJ15 = ObjectPoolingManager.current.GetPooledJunc15();
                if (objJ15 == null) return;

                JuncObjInstantiated(objJ15);

                break;
            case 16:

                GameObject objJ16 = ObjectPoolingManager.current.GetPooledJunc16();
                if (objJ16 == null) return;

                JuncObjInstantiated(objJ16);

                break;

            default:

                break;
        }
    }
    #endregion

    void JuncObjInstantiated(GameObject InstJuncObject)
    {
        GameObject objILJ = ObjectPoolingManager.current.GetPooledInstLocs();
        if (objILJ == null) return;

        objILJ.transform.position = OrigParTran.position;
        objILJ.transform.rotation = Quaternion.identity;
        objILJ.transform.localScale = new Vector3(1, 1, 1);
        objILJ.SetActive(true);

        if (NodeParObj == null)
        {
            NodeParObj = GameObject.FindWithTag("nodeObj");
            objILJ.transform.parent = NodeParObj.transform;
        }
        else
        {
            objILJ.transform.parent = NodeParObj.transform;
        }

        InstJuncObject.transform.position = OrigParTran.position;
        //InstObject.transform.rotation = OrigParTran.rotation;
        InstJuncObject.transform.rotation = Quaternion.identity;
        InstJuncObject.transform.localScale = new Vector3(1, 1, 1);
        InstJuncObject.SetActive(true);

        InstJuncObject.GetComponent<UpdatePosWithScale>().origPos = objILJ.transform;
        //InstExtObj();
        if (ListController == null)
        {
            ListController = GameObject.FindWithTag("managerList");

            ListController.GetComponent<ListControl>().ScaleAll();
            if (!ListController.GetComponent<ListControl>().NonScaleableObjs.Contains(InstJuncObject))
            {
                ListController.GetComponent<ListControl>().NonScaleableObjs.Add(InstJuncObject);
            }

            if (!ListController.GetComponent<ListControl>().DistanceCheckList.Contains(InstJuncObject.transform.GetChild(1).GetComponent<ObjRotValue>().InstPos.gameObject))
            {
                ListController.GetComponent<ListControl>().DistanceCheckList.Add(InstJuncObject.transform.GetChild(1).GetComponent<ObjRotValue>().InstPos.gameObject);
            }
        }
        else
        {
            ListController.GetComponent<ListControl>().ScaleAll();
            if (!ListController.GetComponent<ListControl>().NonScaleableObjs.Contains(InstJuncObject))
            {
                ListController.GetComponent<ListControl>().NonScaleableObjs.Add(InstJuncObject);
            }

            if (!ListController.GetComponent<ListControl>().DistanceCheckList.Contains(InstJuncObject.transform.GetChild(1).GetComponent<ObjRotValue>().InstPos.gameObject))
            {
                ListController.GetComponent<ListControl>().DistanceCheckList.Add(InstJuncObject.transform.GetChild(1).GetComponent<ObjRotValue>().InstPos.gameObject);
            }
        }
        //ParentObj.transform.position = InstJuncObject.transform.GetChild(1).GetComponent<ObjRotValue>().InstPos.position;
        //ParentObj.transform.SetParent(InstJuncObject.transform);

        //InstStartExtObj();
        InstExtObj();
    }

    void ExtObjInstantiated(GameObject InstExtObject)
    {
        
        GameObject objIL = ObjectPoolingManager.current.GetPooledInstLocs();
        if (objIL == null) return;

        objIL.transform.position = OrigParTran.position;
        objIL.transform.rotation = Quaternion.identity;
        objIL.transform.localScale = new Vector3(1, 1, 1);
        objIL.SetActive(true);

        if (NodeParObj == null)
        {
            NodeParObj = GameObject.FindWithTag("nodeObj");

            objIL.transform.parent = NodeParObj.transform;
        }
        else
        {
            objIL.transform.parent = NodeParObj.transform;
        }

        InstExtObject.transform.position = OrigParTran.position;
        InstExtObject.transform.rotation = Quaternion.identity;
        InstExtObject.transform.localScale = new Vector3(1, 1, 1);
        InstExtObject.SetActive(true);

        InstExtObject.GetComponent<UpdatePosWithScale>().origPos = objIL.transform;

        if (ListController == null)
        {
            ListController = GameObject.FindWithTag("managerList");

            ListController.GetComponent<ListControl>().ScaleAll();

            if (!ListController.GetComponent<ListControl>().ScaleableObjs.Contains(InstExtObject))
            {
                ListController.GetComponent<ListControl>().ScaleableObjs.Add(InstExtObject);
            }

            if (!ListController.GetComponent<ListControl>().ExtObjs.Contains(InstExtObject))
            {
                ListController.GetComponent<ListControl>().ExtObjs.Add(InstExtObject);
            }
        }
        else
        {


            ListController.GetComponent<ListControl>().ScaleAll();

            if (!ListController.GetComponent<ListControl>().ScaleableObjs.Contains(InstExtObject))
            {
                ListController.GetComponent<ListControl>().ScaleableObjs.Add(InstExtObject);
            }

            if (!ListController.GetComponent<ListControl>().ExtObjs.Contains(InstExtObject))
            {
                ListController.GetComponent<ListControl>().ExtObjs.Add(InstExtObject);
            }
        }
       /* if (!ListController.GetComponent<ListControl>().DistanceCheckList.Contains(InstExtObject))
        {
            ListController.GetComponent<ListControl>().DistanceCheckList.Add(InstExtObject);
        }*/

        GameObject objILJ = ObjectPoolingManager.current.GetPooledInstLocs();
        if (objILJ == null) return;

        objILJ.transform.position = InstExtObject.transform.GetChild(0).transform.GetChild(1).GetComponent<EXTMIDscript>().InstPivotObj.position;

        /*
        if (posWhileAnimated != null)
        {
            StopCoroutine(posWhileAnimated);
        }

        posWhileAnimated = UpdateThePos(Vector3 moveHere, float tempTimer);
        StartCoroutine(posWhileAnimated);
        */

        objILJ.transform.rotation = Quaternion.identity;
        objILJ.transform.localScale = new Vector3(1, 1, 1);
        objILJ.SetActive(true);

        if (NodeParObj == null)
        {
            NodeParObj = GameObject.FindWithTag("nodeObj");

            objILJ.transform.parent = NodeParObj.transform;
        }
        else
        {
            objILJ.transform.parent = NodeParObj.transform;
        }

        ParentObj.transform.position = objILJ.transform.position;

        ParentObj.GetComponent<UpdatePosWithScale>().origPos = objILJ.transform;
        //ParentObj.transform.SetParent(InstExtObject.transform);

        
        ResetRandom();
    }

    IEnumerator UpdateThePos(Vector3 moveHere, float tempTimer)
    {
        
        while(tempTimer<2.0f)
        {
            tempTimer += Time.deltaTime;
            ParentObj.transform.position = moveHere;
            yield return null;
        }
        yield return null;
        
    }

    void ResetRandom()
    {

        AcceptableJuncInst = 17;
        AcceptableExtInst = 17;

        RunRandJUNC();
        RunRandEXT();

        //Debug.Log("ext is " +);
        //Debug.Log("junc is " + );
    }
    void InstObj()
    {
        if (!budBool)
        {
            InstBud();
            budBool = true;
        }
        else if (!extBool)
        {
            InstStartExtObj();
            //InstExtObj();
            extBool = true;
        }
        else
        {
            InstJuncObj();
        }

        //Debug.Log(randomInst);
        /*if (randomInst == 1)
        {
            if (juncBool == false)
            {
                InstJuncObj();
                juncBool = true;
            }
            else
            {
                InstExtObj();
                extCount++;
                juncBool = false;
            }
        }
        else
        {
            if (extCount < 3)
            {
                extCount++;
                InstExtObj();
            }
            else
            {                
                InstJuncObj();
                juncBool = true;
                extCount = 0;
            }
        }*/
    }

    void RunRandEXT()
    {

        if (randExt != null)
        {
            StopCoroutine(randExt);
        }

        randExt = RandEXTGen();
        StartCoroutine(randExt);
    }

    void RunRandJUNC()
    {
        if (randJunc != null)
        {
            StopCoroutine(randJunc);
        }

        randJunc = RandJUNCGen();
        StartCoroutine(randJunc);
    }

    IEnumerator RandEXTGen()
    {
        while (AcceptableExtInst == 17)
        {            
            //Debug.Log("AcceptableExtInst = " + AcceptableExtInst);
            CheckRandEXT(Random.Range(0, 17));
            yield return null;
        }
        yield return null;
        
    }

    IEnumerator RandJUNCGen()
    {
        while (AcceptableJuncInst == 17)
        {
            //Debug.Log("AcceptableJuncInst = " + AcceptableJuncInst);
            CheckRandJUNC(Random.Range(0, 17));
            yield return null;
        }
        yield return null;
        
    }

    void CheckRandEXT(int tempInstEVal)
    {
        //Debug.Log(tempInstEVal);
        switch (thisRot)
        {
            case 0:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 5))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);                    
                }
                break;
            case 1:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 2:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 3:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 4:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 5:
                if ((tempInstEVal == 0) ||
                    (tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 16))
                {
                    //Debug.Log("It Got Here");

                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    
                    tempInstEVal = Random.Range(0, 17);
                    //Debug.Log("random is called again " + tempInstEVal);
                    //Debug.Log(Random.Range(0, 17));
                }
                break;
            case 6:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 11))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 7:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 8:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 9:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 10:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 11:
                if ((tempInstEVal == 6) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 12:
                if ((tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 13:
                if ((tempInstEVal == 1) ||
                    (tempInstEVal == 2) ||
                    (tempInstEVal == 7) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 12) ||
                    (tempInstEVal == 13) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 14:
                if ((tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 15:
                if ((tempInstEVal == 3) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 9) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 14) ||
                    (tempInstEVal == 15) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;
            case 16:
                if ((tempInstEVal == 2) ||
                    (tempInstEVal == 4) ||
                    (tempInstEVal == 5) ||
                    (tempInstEVal == 8) ||
                    (tempInstEVal == 10) ||
                    (tempInstEVal == 11) ||
                    (tempInstEVal == 13) ||
                    (tempInstEVal == 15) ||
                    (tempInstEVal == 16))
                {
                    AcceptableExtInst = tempInstEVal;
                    StopCoroutine(randExt);
                }
                else
                {
                    tempInstEVal = Random.Range(0, 17);
                }
                break;

            default:

                break;
        }

        //Debug.Log("AcceptableExtInst = " + AcceptableExtInst);

    }

    void CheckRandJUNC(int tempInstVal)
    {
        //Debug.Log(tempInstVal);
        switch (thisRot)
        {
            case 0:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 5))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 1:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 12) ||
                    (tempInstVal == 13))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 2:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 12) ||
                    (tempInstVal == 13) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);                    
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 3:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15))
                {
                    tempInstVal = Random.Range(0, 17);                    
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 4:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 5:
                if ((tempInstVal == 0) ||
                    (tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 6:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 11))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 7:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 12) ||
                    (tempInstVal == 13))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 8:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 12) || 
                    (tempInstVal == 13) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 9:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 10:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 11:
                if ((tempInstVal == 6) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 12:
                if ((tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 12) ||
                    (tempInstVal == 13))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 13:
                if ((tempInstVal == 1) ||
                    (tempInstVal == 2) ||
                    (tempInstVal == 7) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 12) ||
                    (tempInstVal == 13) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 14:
                if ((tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 15:
                if ((tempInstVal == 3) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 9) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 14) ||
                    (tempInstVal == 15) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;
            case 16:
                if ((tempInstVal == 2) ||
                    (tempInstVal == 4) ||
                    (tempInstVal == 5) ||
                    (tempInstVal == 8) ||
                    (tempInstVal == 10) ||
                    (tempInstVal == 11) ||
                    (tempInstVal == 13) ||
                    (tempInstVal == 15) ||
                    (tempInstVal == 16))
                {
                    tempInstVal = Random.Range(0, 17);
                }
                else
                {
                    AcceptableJuncInst = tempInstVal;
                    StopCoroutine(randJunc);
                }
                break;

            default:

                break;
        }

        //Debug.Log("AcceptableJuncInst = " + AcceptableJuncInst);

    }
    
    public void GotHit()
    {
        //randomInst = Random.Range(0, 4);
        //Debug.Log(randomInst);
        InstObj();
        
        //Debug.Log("fffffff");
        //check rot value

        //if junc, inst on top, with a far value, away from others

        //if there's no space, it's ext

        //if ext, inst ext close to rot value or the same
    }
}
