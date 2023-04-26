using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas7Script : MonoBehaviour
{
    public AudioSource audioSrc;
    public GameObject modelHighlighterSelf;
    public GameObject modelTarget;
    public GameObject canvas7UI;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("canvas7");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator canvas7()
    {
        yield return new WaitForSeconds(4);
        canvas7UI.SetActive(true);
        audioSrc.Play();
        yield return new WaitForSeconds(12);
        canvas7UI.SetActive(false);
        modelHighlighterSelf.SetActive(true);
        modelTarget.SetActive(true);
    }
}
