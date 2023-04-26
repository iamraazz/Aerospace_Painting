using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivityCompleteUI : MonoBehaviour
{
    public GameObject canvasDeactive;
    public GameObject canvasActive;
    
    public GameObject taskDoer;
    public GameObject continueUI;
    [SerializeField] GameObject mainModel;
    public bool isFound = false;
    //public GameObject cloth;
    // Start is called before the first frame update
    void Start()
    {
        mainModel = GameObject.Find("MainModelPaintable(Clone)");
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainModel")
        {
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            continueUI.SetActive(true);

            

        }
    }


    public void OnClickRestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnClickExitButton()
    {
        Application.Quit();
    }

    public void OnClickWalkthrough()
    {
        canvasActive.SetActive(false);
    }

    public void OnClickNext()
    {
        canvasDeactive.SetActive(false);
        canvasActive.SetActive(true);
        taskDoer.SetActive(false);
        Destroy(mainModel);
        gameObject.SetActive(false);
    }

    public void OnClickRedo()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        Destroy(mainModel);
        //taskDoer.SetActive(false);
        continueUI.SetActive(false);
        canvasDeactive.SetActive(false);
        canvasDeactive.SetActive(true);
        gameObject.SetActive(false);
        
    }

}
