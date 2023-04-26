using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas6Script : MonoBehaviour
{
    public GameObject canvas4UI;
    public GameObject ovenTarget;
    public GameObject handleHighlighterC4;
    // Start is called before the first frame update
    void Start()
    {
        canvas4UI.SetActive(true);
        StartCoroutine("canvas6");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator canvas6()
    {
        yield return new WaitForSeconds(12);
        canvas4UI.SetActive(false);
        ovenTarget.SetActive(true);
        handleHighlighterC4.SetActive(true);
    }
}
