using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleOpen : MonoBehaviour
{
    public BoxCollider boxCollider;
    public GameObject handleHighlighter;
    public Animator openOvenDoorAnim;
    public GameObject ovenTarget;
    //public AudioSource placeObjectAudioSrc;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        //placeObjectAudioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            openOvenDoorAnim.Play("ovenOpen");
            handleHighlighter.GetComponent<Animator>().enabled = false;
            handleHighlighter.GetComponent<MeshRenderer>().enabled = false;
            //handleHighlighter.transform.GetChild(0).GetComponent<GameObject>().SetActive(false);
            StartCoroutine("handleOpen");
        }
    }

    IEnumerator handleOpen()
    {
        //placeObjectAudioSrc.Play();
        yield return new WaitForSeconds(3f);
        handleHighlighter.SetActive(false);
        ovenTarget.SetActive(false);
    }


}