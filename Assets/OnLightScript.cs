using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLightScript : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
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
        if ((other.tag == "RightHand") || (other.tag == "LeftHand"))
        {
            for (int i = 0; i <= objectsToDeactivate.Length; i ++)
                {
                     objectsToDeactivate[i].SetActive(false);
                }
        }
    }
}
