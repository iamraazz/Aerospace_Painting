using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollide : MonoBehaviour
{
    public Transform backOnTable_bottle;
    public Transform backOnTable_model;
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
        if (other.tag == "TaskDoer")
        { 
            other.transform.position = backOnTable_bottle.transform.position;
            other.transform.rotation = backOnTable_bottle.transform.rotation;
        }

        if (other.tag == "MainModel")
        {
            other.transform.position = backOnTable_model.transform.position;
            other.transform.rotation = backOnTable_model.transform.rotation;
        }
    }
}
