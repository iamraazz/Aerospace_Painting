using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHighlighterFinTableCanvas4 : MonoBehaviour
{
    public GameObject mainModel;
    public GameObject waterSpray;
    public GameObject modelTable;
    public AudioSource audioSrc;
    public GameObject canvas4;
    public GameObject canvas5;
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

            mainModel.transform.position = modelTable.transform.position;
            mainModel.transform.rotation = modelTable.transform.rotation;
            modelTable.GetComponent<Animator>().enabled = false;
            modelTable.GetComponent<MeshRenderer>().enabled = false;
            mainModel.SetActive(false);
            waterSpray.SetActive(false);
            canvas4.SetActive(false);
            canvas5.SetActive(true);
            modelTable.SetActive(false);
            
            //StartCoroutine("modelHighlighterFinTable");
        }
    }

    //IEnumerator modelHighlighterFinTable()
    //{
    //    yield return new WaitForSeconds(5);
    //    audioSrc.Play();
        

    //}
}
