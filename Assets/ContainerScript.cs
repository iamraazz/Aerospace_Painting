using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScript : MonoBehaviour
{
    public AudioSource audioSrc;
    public GameObject oldSwitch;
    public GameObject newSwitch;
    public GameObject switchTarget;
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
        if (other.tag == "UVLight")
        {
            StartCoroutine("container");

        }
    }

    IEnumerator container()
    {
        yield return new WaitForSeconds(8);
        if (!audioSrc.isPlaying)
        {
            audioSrc.Play();
        }
        yield return new WaitForSeconds(4.5f);
        audioSrc.enabled = false;
        
        oldSwitch.SetActive(false);
        newSwitch.SetActive(true);
        switchTarget.SetActive(true);
        //new switch with confetti effects
    }
}
