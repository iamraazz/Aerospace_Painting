using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterContainer : MonoBehaviour
{
    public GameObject mainModel;
    public GameObject modelContainer;
    public AudioSource audioSrc;
    public GameObject switchTarget;
    public GameObject switchHighlighter;
    public ModelHighlighterSelf modelSelfScript;
    // Start is called before the first frame update
    void Start()
    {
        switchHighlighter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainModel")
        {
            
            mainModel.transform.position = modelContainer.transform.position;
            mainModel.transform.rotation = modelContainer.transform.rotation;
            modelContainer.GetComponent<Animator>().enabled = false;
            modelContainer.GetComponent<MeshRenderer>().enabled = false;

            StartCoroutine("modelHighlighterContainer");
        }
    }

    IEnumerator modelHighlighterContainer()
    {
        audioSrc.Play();
        switchTarget.SetActive(true);
        switchHighlighter.SetActive(true);
        modelSelfScript.containerTarget.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        this.gameObject.SetActive(false);
    }
}
