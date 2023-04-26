using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleOpenCanvas4 : MonoBehaviour
{
    public GameObject modelTarget;
    public AudioSource pickObjPlaceOnTableAudio;
    public GameObject ovenTarget;
    public GameObject toolTip_OpenOven;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            ovenTarget.SetActive(false);
            modelTarget.SetActive(true);
            pickObjPlaceOnTableAudio.Play();
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            toolTip_OpenOven.SetActive(false);
            StartCoroutine("handleOpen");
        }
    }

    IEnumerator handleOpen()
    {
     
        yield return new WaitForSeconds(2.5f);
        gameObject.SetActive(false);
    }
}
