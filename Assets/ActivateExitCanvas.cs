using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExitCanvas : MonoBehaviour
{
    public GameObject exitCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("canvasExit");
    }
    IEnumerator canvasExit()
    {
        yield return new WaitForSeconds(5);
        exitCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
