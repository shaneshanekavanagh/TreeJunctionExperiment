using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    #region
    public static ObjectPoolingManager current;

    public GameObject JuncObj0;
    public GameObject JuncObj1;
    public GameObject JuncObj2;
    public GameObject JuncObj3;
    public GameObject JuncObj4;
    public GameObject JuncObj5;
    public GameObject JuncObj6;
    public GameObject JuncObj7;
    public GameObject JuncObj8;
    public GameObject JuncObj9;
    public GameObject JuncObj10;
    public GameObject JuncObj11;
    public GameObject JuncObj12;
    public GameObject JuncObj13;
    public GameObject JuncObj14;
    public GameObject JuncObj15;
    public GameObject JuncObj16;

    public GameObject extObj0;
    public GameObject extObj1;
    public GameObject extObj2;
    public GameObject extObj3;
    public GameObject extObj4;
    public GameObject extObj5;
    public GameObject extObj6;
    public GameObject extObj7;
    public GameObject extObj8;
    public GameObject extObj9;
    public GameObject extObj10;
    public GameObject extObj11;
    public GameObject extObj12;
    public GameObject extObj13;
    public GameObject extObj14;
    public GameObject extObj15;
    public GameObject extObj16;
    
    public GameObject BudObj;

    public GameObject FlowerObj;

    public GameObject LeafObj;

    public GameObject Starter;

    public GameObject InstLoc;

    public GameObject woodPart;

    public int pooledAmount = 20;
    public bool willGrow = true;

    public List<GameObject> pooledJuncs0;
    public List<GameObject> pooledJuncs1;
    public List<GameObject> pooledJuncs2;
    public List<GameObject> pooledJuncs3;
    public List<GameObject> pooledJuncs4;
    public List<GameObject> pooledJuncs5;
    public List<GameObject> pooledJuncs6;
    public List<GameObject> pooledJuncs7;
    public List<GameObject> pooledJuncs8;
    public List<GameObject> pooledJuncs9;
    public List<GameObject> pooledJuncs10;
    public List<GameObject> pooledJuncs11;
    public List<GameObject> pooledJuncs12;
    public List<GameObject> pooledJuncs13;
    public List<GameObject> pooledJuncs14;
    public List<GameObject> pooledJuncs15;
    public List<GameObject> pooledJuncs16;

    public List<GameObject> pooledExts0;
    public List<GameObject> pooledExts1;
    public List<GameObject> pooledExts2;
    public List<GameObject> pooledExts3;
    public List<GameObject> pooledExts4;
    public List<GameObject> pooledExts5;
    public List<GameObject> pooledExts6;
    public List<GameObject> pooledExts7;
    public List<GameObject> pooledExts8;
    public List<GameObject> pooledExts9;
    public List<GameObject> pooledExts10;
    public List<GameObject> pooledExts11;
    public List<GameObject> pooledExts12;
    public List<GameObject> pooledExts13;
    public List<GameObject> pooledExts14;
    public List<GameObject> pooledExts15;
    public List<GameObject> pooledExts16;
    
    public List<GameObject> pooledBuds;

    public List<GameObject> pooledFlows;

    public List<GameObject> pooledLeafs;

    public List<GameObject> pooledInstLocs;

    public List<GameObject> pooledWoodParts;

    IEnumerator BuildIEnum;

    //public GameObject FadeManagerObj;

    //bool built = false;
    #endregion
    private void Awake()
    {
        current = this;
    }

    void Start()
    {
        RunBuilder();
    }

    void RunBuilder()
    {
        if (BuildIEnum != null)
        {
            StopCoroutine(BuildIEnum);
        }

        BuildIEnum = BuildI();
        StartCoroutine(BuildIEnum);
    }
    
    void StopBuilder()
    {
        StopCoroutine(BuildIEnum);

        Starter.GetComponent<GotStarted>().Started();
    }

    IEnumerator BuildI()
    {
        //pooled juncs
        #region
        pooledJuncs0 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ0 = (GameObject)Instantiate(JuncObj0);
            objJ0.SetActive(false);            
            pooledJuncs0.Add(objJ0);
            //yield return null;
        }

        pooledJuncs1 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ1 = (GameObject)Instantiate(JuncObj1);
            objJ1.SetActive(false);
            pooledJuncs1.Add(objJ1);
            //yield return null;
        }

        pooledJuncs2 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ2 = (GameObject)Instantiate(JuncObj2);
            objJ2.SetActive(false);
            pooledJuncs2.Add(objJ2);
            //yield return null;
        }

        pooledJuncs3 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ3 = (GameObject)Instantiate(JuncObj3);
            objJ3.SetActive(false);
            pooledJuncs3.Add(objJ3);
            yield return null;
        }

        pooledJuncs4 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ4 = (GameObject)Instantiate(JuncObj4);
            objJ4.SetActive(false);
            pooledJuncs4.Add(objJ4);
            //yield return null;
        }

        pooledJuncs5 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ5 = (GameObject)Instantiate(JuncObj5);
            objJ5.SetActive(false);
            pooledJuncs5.Add(objJ5);
            //yield return null;
        }

        pooledJuncs6 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ6 = (GameObject)Instantiate(JuncObj6);
            objJ6.SetActive(false);
            pooledJuncs6.Add(objJ6);
            //yield return null;
        }

        pooledJuncs7 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ7 = (GameObject)Instantiate(JuncObj7);
            objJ7.SetActive(false);
            pooledJuncs7.Add(objJ7);
            yield return null;
        }

        pooledJuncs8 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ8 = (GameObject)Instantiate(JuncObj8);
            objJ8.SetActive(false);
            pooledJuncs8.Add(objJ8);
            //yield return null;
        }

        pooledJuncs9 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ9 = (GameObject)Instantiate(JuncObj9);
            objJ9.SetActive(false);
            pooledJuncs9.Add(objJ9);
            //yield return null;
        }

        pooledJuncs10 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ10 = (GameObject)Instantiate(JuncObj10);
            objJ10.SetActive(false);
            pooledJuncs10.Add(objJ10);
            //yield return null;
        }

        pooledJuncs11 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ11 = (GameObject)Instantiate(JuncObj11);
            objJ11.SetActive(false);
            pooledJuncs11.Add(objJ11);
            yield return null;
        }

        pooledJuncs12 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ12 = (GameObject)Instantiate(JuncObj12);
            objJ12.SetActive(false);
            pooledJuncs12.Add(objJ12);
            //yield return null;
        }

        pooledJuncs13 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ13 = (GameObject)Instantiate(JuncObj13);
            objJ13.SetActive(false);
            pooledJuncs13.Add(objJ13);
            //yield return null;
        }

        pooledJuncs14 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ14 = (GameObject)Instantiate(JuncObj14);
            objJ14.SetActive(false);
            pooledJuncs14.Add(objJ14);
            //yield return null;
        }

        pooledJuncs15 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ15 = (GameObject)Instantiate(JuncObj15);
            objJ15.SetActive(false);
            pooledJuncs15.Add(objJ15);
            yield return null;
        }

        pooledJuncs16 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objJ16 = (GameObject)Instantiate(JuncObj16);
            objJ16.SetActive(false);
            pooledJuncs16.Add(objJ16);
            //yield return null;
        }
        #endregion


        //pooled exts
        #region
        pooledExts0 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE0 = (GameObject)Instantiate(extObj0);
            objE0.SetActive(false);
            pooledExts0.Add(objE0);
            //yield return null;
        }

        pooledExts1 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE1 = (GameObject)Instantiate(extObj1);
            objE1.SetActive(false);
            pooledExts1.Add(objE1);
            //yield return null;
        }

        pooledExts2 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE2 = (GameObject)Instantiate(extObj2);
            objE2.SetActive(false);
            pooledExts2.Add(objE2);
            yield return null;
        }

        pooledExts3 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE3 = (GameObject)Instantiate(extObj3);
            objE3.SetActive(false);
            pooledExts3.Add(objE3);
            //yield return null;
        }

        pooledExts4 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE4 = (GameObject)Instantiate(extObj4);
            objE4.SetActive(false);
            pooledExts4.Add(objE4);
            //yield return null;
        }

        pooledExts5 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE5 = (GameObject)Instantiate(extObj5);
            objE5.SetActive(false);
            pooledExts5.Add(objE5);
            //yield return null;
        }

        pooledExts6 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE6 = (GameObject)Instantiate(extObj6);
            objE6.SetActive(false);
            pooledExts6.Add(objE6);
            yield return null;
        }

        pooledExts7 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE7 = (GameObject)Instantiate(extObj7);
            objE7.SetActive(false);
            pooledExts7.Add(objE7);
            //yield return null;
        }

        pooledExts8 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE8 = (GameObject)Instantiate(extObj8);
            objE8.SetActive(false);
            pooledExts8.Add(objE8);
            //yield return null;
        }

        pooledExts9 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE9 = (GameObject)Instantiate(extObj9);
            objE9.SetActive(false);
            pooledExts9.Add(objE9);
            //yield return null;
        }

        pooledExts10 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE10 = (GameObject)Instantiate(extObj10);
            objE10.SetActive(false);
            pooledExts10.Add(objE10);
            yield return null;
        }

        pooledExts11 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE11 = (GameObject)Instantiate(extObj11);
            objE11.SetActive(false);
            pooledExts11.Add(objE11);
            //yield return null;
        }

        pooledExts12 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE12 = (GameObject)Instantiate(extObj12);
            objE12.SetActive(false);
            pooledExts12.Add(objE12);
            //yield return null;
        }

        pooledExts13 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE13 = (GameObject)Instantiate(extObj13);
            objE13.SetActive(false);
            pooledExts13.Add(objE13);
            //yield return null;
        }

        pooledExts14 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE14 = (GameObject)Instantiate(extObj14);
            objE14.SetActive(false);
            pooledExts14.Add(objE14);
            yield return null;
        }

        pooledExts15 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE15 = (GameObject)Instantiate(extObj15);
            objE15.SetActive(false);
            pooledExts15.Add(objE15);
            //yield return null;
        }

        pooledExts16 = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objE16 = (GameObject)Instantiate(extObj16);
            objE16.SetActive(false);
            pooledExts16.Add(objE16);
            //yield return null;
        }
        #endregion

        pooledBuds = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objB = (GameObject)Instantiate(BudObj);
            objB.SetActive(false);
            pooledBuds.Add(objB);
            //yield return null;
        }

        pooledFlows = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objF = (GameObject)Instantiate(FlowerObj);
            objF.SetActive(false);
            pooledFlows.Add(objF);
            yield return null;
        }

        pooledLeafs = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objL = (GameObject)Instantiate(LeafObj);
            objL.SetActive(false);
            pooledLeafs.Add(objL);
            //yield return null;
        }

        pooledInstLocs = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objIL = (GameObject)Instantiate(InstLoc);
            objIL.SetActive(false);
            pooledInstLocs.Add(objIL);
            //yield return null;
        }

        pooledWoodParts = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject objWP = (GameObject)Instantiate(woodPart);
            objWP.SetActive(false);
            pooledWoodParts.Add(objWP);
            //yield return null;
        }

        yield return null;

        StopBuilder();
    }

    //get juncs
    #region
    public GameObject GetPooledJunc0()
    {
        for (int i = 0; i < pooledJuncs0.Count; i++)
        {
            if (!pooledJuncs0[i].activeInHierarchy)
            {
                return pooledJuncs0[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ0 = (GameObject)Instantiate(JuncObj0);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs0.Add(objJ0);
            return objJ0;
        }
        return null;
    }

    public GameObject GetPooledJunc1()
    {
        for (int i = 0; i < pooledJuncs1.Count; i++)
        {
            if (!pooledJuncs1[i].activeInHierarchy)
            {
                return pooledJuncs1[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ1 = (GameObject)Instantiate(JuncObj1);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs1.Add(objJ1);
            return objJ1;
        }
        return null;
    }

    public GameObject GetPooledJunc2()
    {
        for (int i = 0; i < pooledJuncs2.Count; i++)
        {
            if (!pooledJuncs2[i].activeInHierarchy)
            {
                return pooledJuncs2[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ2 = (GameObject)Instantiate(JuncObj2);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs2.Add(objJ2);
            return objJ2;
        }
        return null;
    }

    public GameObject GetPooledJunc3()
    {
        for (int i = 0; i < pooledJuncs3.Count; i++)
        {
            if (!pooledJuncs3[i].activeInHierarchy)
            {
                return pooledJuncs3[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ3 = (GameObject)Instantiate(JuncObj3);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs3.Add(objJ3);
            return objJ3;
        }
        return null;
    }

    public GameObject GetPooledJunc4()
    {
        for (int i = 0; i < pooledJuncs4.Count; i++)
        {
            if (!pooledJuncs4[i].activeInHierarchy)
            {
                return pooledJuncs4[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ4 = (GameObject)Instantiate(JuncObj4);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs4.Add(objJ4);
            return objJ4;
        }
        return null;
    }

    public GameObject GetPooledJunc5()
    {
        for (int i = 0; i < pooledJuncs5.Count; i++)
        {
            if (!pooledJuncs5[i].activeInHierarchy)
            {
                return pooledJuncs5[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ5 = (GameObject)Instantiate(JuncObj5);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs5.Add(objJ5);
            return objJ5;
        }
        return null;
    }

    public GameObject GetPooledJunc6()
    {
        for (int i = 0; i < pooledJuncs6.Count; i++)
        {
            if (!pooledJuncs6[i].activeInHierarchy)
            {
                return pooledJuncs6[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ6 = (GameObject)Instantiate(JuncObj6);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs6.Add(objJ6);
            return objJ6;
        }
        return null;
    }

    public GameObject GetPooledJunc7()
    {
        for (int i = 0; i < pooledJuncs7.Count; i++)
        {
            if (!pooledJuncs7[i].activeInHierarchy)
            {
                return pooledJuncs7[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ7 = (GameObject)Instantiate(JuncObj7);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs7.Add(objJ7);
            return objJ7;
        }
        return null;
    }

    public GameObject GetPooledJunc8()
    {
        for (int i = 0; i < pooledJuncs8.Count; i++)
        {
            if (!pooledJuncs8[i].activeInHierarchy)
            {
                return pooledJuncs8[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ8 = (GameObject)Instantiate(JuncObj8);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs8.Add(objJ8);
            return objJ8;
        }
        return null;
    }

    public GameObject GetPooledJunc9()
    {
        for (int i = 0; i < pooledJuncs9.Count; i++)
        {
            if (!pooledJuncs9[i].activeInHierarchy)
            {
                return pooledJuncs9[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ9 = (GameObject)Instantiate(JuncObj9);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs9.Add(objJ9);
            return objJ9;
        }
        return null;
    }

    public GameObject GetPooledJunc10()
    {
        for (int i = 0; i < pooledJuncs10.Count; i++)
        {
            if (!pooledJuncs10[i].activeInHierarchy)
            {
                return pooledJuncs10[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ10 = (GameObject)Instantiate(JuncObj10);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs10.Add(objJ10);
            return objJ10;
        }
        return null;
    }

    public GameObject GetPooledJunc11()
    {
        for (int i = 0; i < pooledJuncs11.Count; i++)
        {
            if (!pooledJuncs11[i].activeInHierarchy)
            {
                return pooledJuncs11[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ11 = (GameObject)Instantiate(JuncObj11);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs11.Add(objJ11);
            return objJ11;
        }
        return null;
    }

    public GameObject GetPooledJunc12()
    {
        for (int i = 0; i < pooledJuncs12.Count; i++)
        {
            if (!pooledJuncs12[i].activeInHierarchy)
            {
                return pooledJuncs12[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ12 = (GameObject)Instantiate(JuncObj12);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs12.Add(objJ12);
            return objJ12;
        }
        return null;
    }

    public GameObject GetPooledJunc13()
    {
        for (int i = 0; i < pooledJuncs13.Count; i++)
        {
            if (!pooledJuncs13[i].activeInHierarchy)
            {
                return pooledJuncs13[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ13 = (GameObject)Instantiate(JuncObj13);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs13.Add(objJ13);
            return objJ13;
        }
        return null;
    }

    public GameObject GetPooledJunc14()
    {
        for (int i = 0; i < pooledJuncs14.Count; i++)
        {
            if (!pooledJuncs14[i].activeInHierarchy)
            {
                return pooledJuncs14[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ14 = (GameObject)Instantiate(JuncObj14);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs14.Add(objJ14);
            return objJ14;
        }
        return null;
    }

    public GameObject GetPooledJunc15()
    {
        for (int i = 0; i < pooledJuncs15.Count; i++)
        {
            if (!pooledJuncs15[i].activeInHierarchy)
            {
                return pooledJuncs15[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ15 = (GameObject)Instantiate(JuncObj15);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs15.Add(objJ15);
            return objJ15;
        }
        return null;
    }

    public GameObject GetPooledJunc16()
    {
        for (int i = 0; i < pooledJuncs16.Count; i++)
        {
            if (!pooledJuncs16[i].activeInHierarchy)
            {
                return pooledJuncs16[i];
            }
        }

        if (willGrow)
        {
            GameObject objJ16 = (GameObject)Instantiate(JuncObj16);
            //DontDestroyOnLoad(objB.gameObject);
            pooledJuncs16.Add(objJ16);
            return objJ16;
        }
        return null;
    }
    #endregion

    //get exts
    #region
    public GameObject GetPooledExt0()
    {
        for (int i = 0; i < pooledExts0.Count; i++)
        {
            if (!pooledExts0[i].activeInHierarchy)
            {
                return pooledExts0[i];
            }
        }

        if (willGrow)
        {
            GameObject objE0 = (GameObject)Instantiate(extObj0);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts0.Add(objE0);
            return objE0;
        }
        return null;
    }

    public GameObject GetPooledExt1()
    {
        for (int i = 0; i < pooledExts1.Count; i++)
        {
            if (!pooledExts1[i].activeInHierarchy)
            {
                return pooledExts1[i];
            }
        }

        if (willGrow)
        {
            GameObject objE1 = (GameObject)Instantiate(extObj1);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts1.Add(objE1);
            return objE1;
        }
        return null;
    }

    public GameObject GetPooledExt2()
    {
        for (int i = 0; i < pooledExts2.Count; i++)
        {
            if (!pooledExts2[i].activeInHierarchy)
            {
                return pooledExts2[i];
            }
        }

        if (willGrow)
        {
            GameObject objE2 = (GameObject)Instantiate(extObj2);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts2.Add(objE2);
            return objE2;
        }
        return null;
    }

    public GameObject GetPooledExt3()
    {
        for (int i = 0; i < pooledExts3.Count; i++)
        {
            if (!pooledExts3[i].activeInHierarchy)
            {
                return pooledExts3[i];
            }
        }

        if (willGrow)
        {
            GameObject objE3 = (GameObject)Instantiate(extObj3);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts3.Add(objE3);
            return objE3;
        }
        return null;
    }

    public GameObject GetPooledExt4()
    {
        for (int i = 0; i < pooledExts4.Count; i++)
        {
            if (!pooledExts4[i].activeInHierarchy)
            {
                return pooledExts4[i];
            }
        }

        if (willGrow)
        {
            GameObject objE4 = (GameObject)Instantiate(extObj4);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts4.Add(objE4);
            return objE4;
        }
        return null;
    }

    public GameObject GetPooledExt5()
    {
        for (int i = 0; i < pooledExts5.Count; i++)
        {
            if (!pooledExts5[i].activeInHierarchy)
            {
                return pooledExts5[i];
            }
        }

        if (willGrow)
        {
            GameObject objE5 = (GameObject)Instantiate(extObj5);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts5.Add(objE5);
            return objE5;
        }
        return null;
    }

    public GameObject GetPooledExt6()
    {
        for (int i = 0; i < pooledExts6.Count; i++)
        {
            if (!pooledExts6[i].activeInHierarchy)
            {
                return pooledExts6[i];
            }
        }

        if (willGrow)
        {
            GameObject objE6 = (GameObject)Instantiate(extObj6);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts6.Add(objE6);
            return objE6;
        }
        return null;
    }

    public GameObject GetPooledExt7()
    {
        for (int i = 0; i < pooledExts7.Count; i++)
        {
            if (!pooledExts7[i].activeInHierarchy)
            {
                return pooledExts7[i];
            }
        }

        if (willGrow)
        {
            GameObject objE7 = (GameObject)Instantiate(extObj7);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts7.Add(objE7);
            return objE7;
        }
        return null;
    }

    public GameObject GetPooledExt8()
    {
        for (int i = 0; i < pooledExts8.Count; i++)
        {
            if (!pooledExts8[i].activeInHierarchy)
            {
                return pooledExts8[i];
            }
        }

        if (willGrow)
        {
            GameObject objE8 = (GameObject)Instantiate(extObj8);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts8.Add(objE8);
            return objE8;
        }
        return null;
    }

    public GameObject GetPooledExt9()
    {
        for (int i = 0; i < pooledExts9.Count; i++)
        {
            if (!pooledExts9[i].activeInHierarchy)
            {
                return pooledExts9[i];
            }
        }

        if (willGrow)
        {
            GameObject objE9 = (GameObject)Instantiate(extObj9);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts9.Add(objE9);
            return objE9;
        }
        return null;
    }

    public GameObject GetPooledExt10()
    {
        for (int i = 0; i < pooledExts10.Count; i++)
        {
            if (!pooledExts10[i].activeInHierarchy)
            {
                return pooledExts10[i];
            }
        }

        if (willGrow)
        {
            GameObject objE10 = (GameObject)Instantiate(extObj10);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts10.Add(objE10);
            return objE10;
        }
        return null;
    }

    public GameObject GetPooledExt11()
    {
        for (int i = 0; i < pooledExts11.Count; i++)
        {
            if (!pooledExts11[i].activeInHierarchy)
            {
                return pooledExts11[i];
            }
        }

        if (willGrow)
        {
            GameObject objE11 = (GameObject)Instantiate(extObj11);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts11.Add(objE11);
            return objE11;
        }
        return null;
    }

    public GameObject GetPooledExt12()
    {
        for (int i = 0; i < pooledExts12.Count; i++)
        {
            if (!pooledExts12[i].activeInHierarchy)
            {
                return pooledExts12[i];
            }
        }

        if (willGrow)
        {
            GameObject objE12 = (GameObject)Instantiate(extObj12);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts12.Add(objE12);
            return objE12;
        }
        return null;
    }

    public GameObject GetPooledExt13()
    {
        for (int i = 0; i < pooledExts13.Count; i++)
        {
            if (!pooledExts13[i].activeInHierarchy)
            {
                return pooledExts13[i];
            }
        }

        if (willGrow)
        {
            GameObject objE13 = (GameObject)Instantiate(extObj13);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts13.Add(objE13);
            return objE13;
        }
        return null;
    }

    public GameObject GetPooledExt14()
    {
        for (int i = 0; i < pooledExts14.Count; i++)
        {
            if (!pooledExts14[i].activeInHierarchy)
            {
                return pooledExts14[i];
            }
        }

        if (willGrow)
        {
            GameObject objE14 = (GameObject)Instantiate(extObj14);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts14.Add(objE14);
            return objE14;
        }
        return null;
    }

    public GameObject GetPooledExt15()
    {
        for (int i = 0; i < pooledExts15.Count; i++)
        {
            if (!pooledExts15[i].activeInHierarchy)
            {
                return pooledExts15[i];
            }
        }

        if (willGrow)
        {
            GameObject objE15 = (GameObject)Instantiate(extObj15);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts15.Add(objE15);
            return objE15;
        }
        return null;
    }

    public GameObject GetPooledExt16()
    {
        for (int i = 0; i < pooledExts16.Count; i++)
        {
            if (!pooledExts16[i].activeInHierarchy)
            {
                return pooledExts16[i];
            }
        }

        if (willGrow)
        {
            GameObject objE16 = (GameObject)Instantiate(extObj16);
            //DontDestroyOnLoad(objB.gameObject);
            pooledExts16.Add(objE16);
            return objE16;
        }
        return null;
    }
    #endregion

    public GameObject GetPooledBud()
    {
        for (int i = 0; i < pooledBuds.Count; i++)
        {
            if (!pooledBuds[i].activeInHierarchy)
            {
                return pooledBuds[i];
            }
        }

        if (willGrow)
        {
            GameObject objB = (GameObject)Instantiate(BudObj);
            pooledBuds.Add(objB);
            //DontDestroyOnLoad(objD.gameObject);
            return objB;
        }
        return null;
    }

    public GameObject GetPooledFlower()
    {
        for (int i = 0; i < pooledFlows.Count; i++)
        {
            if (!pooledFlows[i].activeInHierarchy)
            {
                return pooledFlows[i];
            }
        }

        if (willGrow)
        {
            GameObject objF = (GameObject)Instantiate(FlowerObj);
            pooledFlows.Add(objF);
            //DontDestroyOnLoad(objD.gameObject);
            return objF;
        }
        return null;
    }

    public GameObject GetPooledLeaf()
    {
        for (int i = 0; i < pooledLeafs.Count; i++)
        {
            if (!pooledLeafs[i].activeInHierarchy)
            {
                return pooledLeafs[i];
            }
        }

        if (willGrow)
        {
            GameObject objL = (GameObject)Instantiate(LeafObj);
            pooledLeafs.Add(objL);
            //DontDestroyOnLoad(objD.gameObject);
            return objL;
        }
        return null;
    }
    
    public GameObject GetPooledInstLocs()
    {
        for (int i = 0; i < pooledInstLocs.Count; i++)
        {
            if (!pooledInstLocs[i].activeInHierarchy)
            {
                return pooledInstLocs[i];
            }
        }

        if (willGrow)
        {
            GameObject objIL = (GameObject)Instantiate(InstLoc);
            pooledInstLocs.Add(objIL);
            //DontDestroyOnLoad(objD.gameObject);
            return objIL;
        }
        return null;
    }

    public GameObject GetPooledWoodParts()
    {
        for (int i = 0; i < pooledWoodParts.Count; i++)
        {
            if (!pooledWoodParts[i].activeInHierarchy)
            {
                return pooledWoodParts[i];
            }
        }

        if (willGrow)
        {
            GameObject objWP = (GameObject)Instantiate(woodPart);
            pooledWoodParts.Add(objWP);
            //DontDestroyOnLoad(objD.gameObject);
            return objWP;
        }
        return null;
    }
}