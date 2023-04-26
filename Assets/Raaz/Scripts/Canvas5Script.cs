using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas5Script : MonoBehaviour
{

    public Animator openOvenDoorAnim;
    [SerializeField] GameObject handleHighlighter;
    [SerializeField] GameObject ovenTarget;
    [SerializeField] AudioSource audioSrc;
    [SerializeField] GameObject dryAirCheckBox;
    [SerializeField] GameObject canvas6;
    // Start is called before the first frame update
    void Start()
    {
        //dryAirCheckBox = GetComponent<GameObject>();
        ovenTarget.SetActive(false);
        handleHighlighter.SetActive(false);
        StartCoroutine("canvas5");
    }

    IEnumerator canvas5()
    {
        yield return new WaitForSeconds(5);
        audioSrc.Play();
        yield return new WaitForSeconds(6);
        ovenTarget.SetActive(true);
        handleHighlighter.SetActive(true);
        //yield return new WaitForSeconds(10);
        //OnClickSkipButton();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickSkipButton()
    {
        Debug.Log("Skip buutton working");
        //ovenTarget.SetActive(false);
        //handleHighlighter.SetActive(false);
        dryAirCheckBox.SetActive(true);
        canvas6.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
