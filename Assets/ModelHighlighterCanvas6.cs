using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterCanvas6 : MonoBehaviour
{
    public GameObject mainModel;
    public GameObject sprayBottle;
    public GameObject canvas6;
    public GameObject canvas7;
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
            mainModel.SetActive(false);
            sprayBottle.SetActive(false);
            canvas7.SetActive(true);
            canvas6.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
