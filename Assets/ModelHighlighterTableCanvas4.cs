using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterTableCanvas4 : MonoBehaviour
{
    public GameObject percentage_ToolTip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("tableCanvas4");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator tableCanvas4()
    {
        yield return new WaitForSeconds(4);
        percentage_ToolTip.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
