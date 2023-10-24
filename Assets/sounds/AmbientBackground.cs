using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientBackground : MonoBehaviour
{
    public AudioSource Strings;
    //public AudioSource Synth;
    public AudioSource Bells1;
    public AudioSource Bells2;

    float StringsLevel;
    float BellsLevel1;
    float BellsLevel2;
    //float SynthLevel;

    int RandSound;
    bool jumbBool;

    IEnumerator jumbleSounds;

    // Start is called before the first frame update
    void Start()
    {
        RandSound = Random.Range(0, 4);
        StringsLevel = 0.0f;
        BellsLevel1 = 0.0f;
        BellsLevel2 = 0.0f;
        //SynthLevel = 0.0f;
        PickASound();
        
    }

    void PickASound()
    {
        if (jumbleSounds != null) { StopCoroutine(jumbleSounds); }

        switch (RandSound)
        {
            case 1:
                Strings.Play();
                break;

            case 2:
                Bells1.Play();
                break;

            case 3:
                Bells2.Play();
                break;

            default:
                break;
        }

        jumbBool = true;
        jumbleSounds = JumbleTheSounds(Random.Range(9.0f, 15.0f));
        StartCoroutine(jumbleSounds);

    }

    IEnumerator JumbleTheSounds(float timedWait)
    {
        RandSound = Random.Range(0, 4);

        yield return new WaitForSeconds(timedWait);
        PickASound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            Strings.Play();

        }

        if (Input.GetKey("s"))
        {
            Bells1.Play();
        }

        if (Input.GetKey("d"))
        {
            Bells2.Play();
        }

        /*
        if (Input.GetKey("a"))
        {
            if (StringsLevel < 1.0f)
            { 
                StringsLevel += 0.1f;
            }
        }
        else
        {
            if (StringsLevel > 0.0f)
            {
                StringsLevel -= 0.1f;
            }
        }
        if (Input.GetKey("s"))
        {
            if (BellsLevel1 < 1.0f)
            {
                BellsLevel1 += 0.1f;
            }
        }
        else
        {
            if(BellsLevel1 > 0.0f)
            {
                BellsLevel1 -= 0.1f;
            }
        }
        if (Input.GetKey("d"))
        {
            if (BellsLevel2 < 1.0f)
            {
                BellsLevel2 += 0.1f;
            }
        }
        else
        {
            if(BellsLevel2 > 0.0f)
            {
                BellsLevel2 -= 0.1f;
            }
        }
        */
        /* if (Input.GetKey("f"))
         {
             if (SynthLevel < 1.0f)
             {
                 SynthLevel += 0.1f;
             }
         }
         else
         {
             if (SynthLevel > 0.0f)
             {
                 SynthLevel -= 0.1f;
             }
         }*/

        //Strings.volume = StringsLevel;
        //Bells1.volume = BellsLevel1;
        //Bells2.volume = BellsLevel2;
        //Synth.volume = SynthLevel;
    }
}
