using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject uiHelpers;
    public bool isOn_UI = false;
    public GameObject welcomeCanvas;
    public GameObject mainModel;
    // Start is called before the first frame update
    void Start()
    {
        isOn_UI = true;
        mainModel.SetActive(false);
        welcomeCanvas.SetActive(true);
        StartCoroutine(welcomeCanvasFunction());
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            if(isOn_UI == true)
            {
                uiHelpers.SetActive(true);
                isOn_UI = false;
            }
            else 
            {
                uiHelpers.SetActive(false);
                isOn_UI = true;
            }
        }
    }


    IEnumerator welcomeCanvasFunction()
    {
        yield return new WaitForSeconds(3);
        welcomeCanvas.SetActive(false);
    }
}
