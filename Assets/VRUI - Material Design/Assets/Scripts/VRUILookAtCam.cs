using UnityEngine;

// VRUI Script For LookAt Camera
namespace SpaceBear.VRUI
{
    [ExecuteAlways]
    public class VRUILookAtCam : MonoBehaviour
    {
        [SerializeField] Transform cam;

        //raziq code below
        void Start()
        {
            Camera camera = GameObject.Find("CenterEyeAnchor").GetComponent<Camera>();
            
            cam = camera.transform;
        }
        void Update()
        {
            if (cam)
            {
                transform.LookAt(cam);
                transform.Rotate(new Vector3(0, 180, 0));
            }

        }
    }
}
