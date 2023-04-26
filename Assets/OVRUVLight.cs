using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRUVLight : MonoBehaviour
{
    public GameObject instrToolTip;
    public GameObject uvLight;
    //public GameObject uvLightHighlighter;
    public GameObject spotlight;
    //public AudioSource uvLightAudio;
    //public GameObject uvLight_ToolTip;
    //public GameObject containerTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (uvLight.GetComponent<OVRGrabbable>().isGrabbed == true)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
            {
                spotlight.SetActive(true);
                instrToolTip.SetActive(false);

            }
        }
        if (uvLight.GetComponent<OVRGrabbable>().isGrabbed == true || uvLight.GetComponent<OVRGrabbable>().isGrabbed == false)
        {
            if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger))
            {
                spotlight.SetActive(false);

            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
    //    {
    //        uvLightHighlighter.GetComponent<Animator>().enabled = false;
    //        uvLightHighlighter.GetComponent<MeshRenderer>().enabled = false;
    //        uvLight_ToolTip.SetActive(false);
    //        containerTarget.SetActive(true);
    //        StartCoroutine("uvLightFunction");

    //    }
    //}

    //IEnumerator uvLightFunction()
    //{
    //    uvLightAudio.Play();
    //    yield return new WaitForSeconds(3.5f);
    //    uvLightHighlighter.SetActive(false);
    //}
}

