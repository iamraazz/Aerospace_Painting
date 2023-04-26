using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothInteraction : MonoBehaviour
{
    public GameObject clothHihglighter;
    public GameObject clothTarget;
    public GameObject modelHighlighterClean;
    ClothInteraction clothInteractionScript;
    // Start is called before the first frame update
    void Start()
    {
        modelHighlighterClean.SetActive(false);
        clothInteractionScript = GetComponent<ClothInteraction>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RightHand")
        {
            StartCoroutine("clothInteraction");
            
        }
    }

    IEnumerator clothInteraction()
    {
        clothHihglighter.SetActive(false);
        clothTarget.SetActive(false);
        modelHighlighterClean.SetActive(true);//add audio to play on awake on this object
        yield return new WaitForSeconds(0.1f);
        clothInteractionScript.enabled = false;
    }

}
