using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas3Script : MonoBehaviour
{
    public GameObject mainModel3;
    public Animator openOvenDoorAnim;
    [SerializeField] GameObject handleHighlighter;
    [SerializeField] GameObject ovenTarget;
    [SerializeField] AudioSource audioSrc;
    [SerializeField] GameObject dwellTimeCheckBox;
    [SerializeField] GameObject canvas4;
    // Start is called before the first frame update
    void Start()
    {
        //dwellTimeCheckBox = GetComponent<GameObject>();
        ovenTarget.SetActive(false);
        handleHighlighter.SetActive(false);
        StartCoroutine("canvas3");
    }

    IEnumerator canvas3()
    {
        mainModel3.SetActive(true);
        yield return new WaitForSeconds(4);
        audioSrc.Play();
        
        yield return new WaitForSeconds(11);
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
        
        ovenTarget.SetActive(false);
        handleHighlighter.SetActive(false);
        dwellTimeCheckBox.SetActive(true);
        canvas4.SetActive(true);
        gameObject.SetActive(false);
        mainModel3.SetActive(false);

        //activate the handle again and place back the object on the table
    }
}
