using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskComplete : MonoBehaviour
{
    public GameObject fill;
    public GameObject done;
    public GameObject modelHighlighterFin;
    public GameObject confetti;
    public GameObject pie_100;

    public void Update()
    {
        if (fill.GetComponent<Image>().fillAmount >= 0.98f)
        {
            Debug.Log("CheckMark ticked");
            fill.GetComponent<Image>().fillAmount = 1f;

            done.SetActive(true);
            modelHighlighterFin.SetActive(true);
            confetti.SetActive(true);
            pie_100.SetActive(true);

        }
    }
}
