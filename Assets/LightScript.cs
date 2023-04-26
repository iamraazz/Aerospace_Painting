using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public ModelHighlighterContainer modelContainerScript;
    public GameObject onSwitch;
    public GameObject offSwitch;
    public AudioSource audioSrc;
    public GameObject uvLightTarget;
    public GameObject lightOffObject;
    public GameObject mainModel;
    public GameObject uvLightModel;
    public GameObject uvLight;
    // Start is called before the first frame update
    void Start()
    {
        lightOffObject.SetActive(false);
        onSwitch.SetActive(true);
        offSwitch.SetActive(false);
        //mainModel.SetActive(true);
        uvLightModel.SetActive(false);
        uvLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            modelContainerScript.switchHighlighter.SetActive(false);
            modelContainerScript.switchTarget.SetActive(false);
            onSwitch.SetActive(false);
            offSwitch.SetActive(true);
            audioSrc.Play();

            uvLightTarget.SetActive(true);
            
            mainModel.SetActive(false);
            uvLightModel.SetActive(true);
            uvLight.SetActive(true);
            lightOffObject.SetActive(true);
            //StartCoroutine("modelHighlighterSelf");
        }
    }
}
