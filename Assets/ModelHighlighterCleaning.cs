using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterCleaning : MonoBehaviour
{
    public GameObject selfObject;
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
        if((other.tag == "TaskDoer") || (other.tag == "RightHand") || (other.tag == "LeftHand"))
            {
                
                StartCoroutine("cleanModel");
            }
        
    }

    IEnumerator cleanModel()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(selfObject);
    }
}
