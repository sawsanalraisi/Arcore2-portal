using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public OVRCameraRig OVRCam;
    public float moveSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickUp))
            OVRCam.transform.position += moveSpeed * new Vector3(OVRCam.transform.position.x, OVRCam.transform.position.y, OVRCam.transform.position.z+1f);


      
    }
}
