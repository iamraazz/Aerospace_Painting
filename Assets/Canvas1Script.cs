using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas1Script : MonoBehaviour
{
    public GameObject clothHihglighter;
    public GameObject clothTarget;
    public GameObject mainModelPrefab;
    public Transform mainModelTransform;
    // Start is called before the first frame update
    void Start()
    {
        clothTarget.SetActive(false);
        clothHihglighter.SetActive(false);
        StartCoroutine("canvas1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator canvas1()
    {
        //Instantiate(mainModelPrefab, mainModelTransform.position, mainModelTransform.rotation);
        yield return new WaitForSeconds(4);
        clothHihglighter.SetActive(true);
        clothTarget.SetActive(true);


    }
}
