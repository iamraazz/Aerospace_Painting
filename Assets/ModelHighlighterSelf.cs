using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterSelf : MonoBehaviour
{
    public BoxCollider boxCollider;
    public AudioSource audioSrc;
    public GameObject modelSelf;
    public GameObject modelContainer;
    public GameObject containerTarget;
    public Canvas7Script canvas7Script;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        modelContainer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            modelSelf.GetComponent<Animator>().enabled = false;
            modelSelf.GetComponent<MeshRenderer>().enabled = false;

            if(!audioSrc.isPlaying)
            {
                audioSrc.Play();
            }

            containerTarget.SetActive(true);
            canvas7Script.modelTarget.SetActive(false);
            StartCoroutine("modelHighlighterSelf");

        }
    }

    IEnumerator modelHighlighterSelf()
    {
        modelContainer.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        this.gameObject.GetComponent<AudioSource>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
