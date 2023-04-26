using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterSelfCanvas4 : MonoBehaviour
{
    public GameObject modelTarget;
    public Animator ovenAnim;
    public Transform mainModel;
    public GameObject waterSprayHighlighter;
    //public GameObject vrui_Canvas_Percentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainModel")
        {
            mainModel.transform.position = gameObject.transform.position;
            mainModel.transform.rotation = gameObject.transform.rotation;
            waterSprayHighlighter.SetActive(true);
            modelTarget.SetActive(false);
            //vrui_Canvas_Percentage.SetActive(true);
            ovenAnim.Play("ovenClose");
            gameObject.SetActive(false);
        }
    }
}
