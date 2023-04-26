using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Transform ovenTarget;
    public float rotationSpeed;
    [SerializeField] private float hideDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var direction = ovenTarget.position - transform.position;
        //var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(ovenTarget.position - transform.position), 
            rotationSpeed * Time.deltaTime);

        if(direction.magnitude < hideDistance)
        {
            SetIndicatorActive(false);
        }
        else
        {
            SetIndicatorActive(true);
        }

    }

    private void SetIndicatorActive(bool isActive)
    {
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(isActive);
        }
    }
}
