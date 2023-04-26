using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanGoodJob : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject modelClean;
    public GameObject cloth;
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
        if(other.tag == "MainModel")
        {
            canvas1.SetActive(false);
            gameObject.SetActive(false);
            canvas2.SetActive(true);
            cloth.SetActive(false);
            modelClean.SetActive(false);

        }
    }

    public void OnClickRedoCanvas3()
    {
        canvas1.SetActive(false);
        gameObject.SetActive(false);
        canvas2.SetActive(true);
        cloth.SetActive(false);
        modelClean.SetActive(false);
    }
}
