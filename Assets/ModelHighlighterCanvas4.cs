using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterCanvas4 : MonoBehaviour
{
    public GameObject waterSpray;
    public GameObject modelHighlighterSelf_C4;

    // Start is called before the first frame update
    void Start()
    {
        waterSpray.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            
            waterSpray.SetActive(true);
            modelHighlighterSelf_C4.SetActive(true);
            StartCoroutine("canvas4ModelHighlighter");
            //activate spray model here
        }
    }

    IEnumerator canvas4ModelHighlighter()
    {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
