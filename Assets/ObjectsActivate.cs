using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsActivate : MonoBehaviour
{
    public GameObject[] objectsToActivate;
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
            for (int i = 0; i <= objectsToActivate.Length; i++)
            {
                objectsToActivate[i].SetActive(true);
            }
        }
    }

    public void OnClickActiveObjects()
    {
        for (int i = 0; i <= objectsToActivate.Length; i++)
        {
            objectsToActivate[i].SetActive(true);
        }
    }
}
