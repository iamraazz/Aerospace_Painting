using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompletedUIPercentage : MonoBehaviour
{
    public GameObject fill;
    public GameObject redoOrNextUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fill.GetComponent<Image>().fillAmount >= 0.98f)
        {
            //percentage_ToolTip.SetActive(false);
            Debug.Log("CheckMark ticked");
            redoOrNextUI.SetActive(true);

        }
    }
}
