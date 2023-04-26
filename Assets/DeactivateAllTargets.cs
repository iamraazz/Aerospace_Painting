using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateAllTargets : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= objectsToDeactivate.Length; i++)
        {
            objectsToDeactivate[i].SetActive(false);
        }
    }
}

