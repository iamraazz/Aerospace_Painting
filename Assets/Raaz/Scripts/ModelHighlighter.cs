using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighter : MonoBehaviour
{
    public GameObject mainModel;
    public GameObject modelHighlighter;
    public GameObject timerCanvas;
    public GameObject timerOven;
    public Animator closeOvenDoorAnim;
    public GameObject ovenTarget;
    public GameObject modelTarget;
    public AudioSource checkTimerAudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        checkTimerAudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainModel")
        {
            
            mainModel.transform.position = modelHighlighter.transform.position;
            mainModel.transform.rotation = modelHighlighter.transform.rotation;
            modelHighlighter.GetComponent<MeshRenderer>().enabled = false;
            modelHighlighter.GetComponent<Animator>().enabled = false;
            timerCanvas.SetActive(true);
            timerOven.SetActive(true);
            closeOvenDoorAnim.Play("ovenClose");
            ovenTarget.SetActive(false);
            modelTarget.SetActive(false);
            StartCoroutine("modelHighlighterFunction");
            

        }
    }

    IEnumerator modelHighlighterFunction()
    {
        if (!checkTimerAudioSrc.isPlaying)
        {
            checkTimerAudioSrc.Play();
        }
        
        yield return new WaitForSeconds(4f);
        modelHighlighter.SetActive(false);
    }
}
