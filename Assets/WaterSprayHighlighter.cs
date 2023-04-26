using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSprayHighlighter : MonoBehaviour
{
    //public AudioSource waterSprayAudio;
    public GameObject spray_ToolTip;
    public GameObject modelHighlighterTable_C4;
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
        if((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            //waterSprayAudio.Play();
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            spray_ToolTip.SetActive(false);
            modelHighlighterTable_C4.SetActive(true);
            StartCoroutine("waterSprayHighlighter");
            
        }
    }

    IEnumerator waterSprayHighlighter()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
