using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CW.Common;

using PaintIn3D;


public class OVRSpray : MonoBehaviour
{
    public GameObject sprayBottle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sprayBottle.GetComponent<OVRGrabbable>().isGrabbed == true)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                sprayBottle.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                sprayBottle.transform.GetChild(1).GetComponent<AudioSource>().Play();

            }
        }
        if (sprayBottle.GetComponent<OVRGrabbable>().isGrabbed == true  || sprayBottle.GetComponent<OVRGrabbable>().isGrabbed == false)
                {
                    if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
                    {
                        sprayBottle.transform.GetChild(0).GetComponent<ParticleSystem>().Stop();
                        sprayBottle.transform.GetChild(1).GetComponent<AudioSource>().Stop();

                    }
                }
            }

    }
