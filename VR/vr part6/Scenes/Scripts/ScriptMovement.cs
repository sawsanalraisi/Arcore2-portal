using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScriptMovement : MonoBehaviour
{


    public GameObject MoveAround;
    public Text Res;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
        {
            MoveAround.transform.position = new Vector3(MoveAround.transform.position.x, MoveAround.transform.position.y, MoveAround.transform.position.z + 0.01f*0.1f);
                Res.text = "Up";
            }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
        {
            MoveAround.transform.position = new Vector3(MoveAround.transform.position.x, MoveAround.transform.position.y, MoveAround.transform.position.z - 0.01f * 0.1f);
                Res.text = "Down";
            }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            MoveAround.transform.position = new Vector3(MoveAround.transform.position.x + 0.01f * 0.1f, MoveAround.transform.position.y, MoveAround.transform.position.z);
                Res.text = "kRight";

            }
        if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            MoveAround.transform.position = new Vector3(MoveAround.transform.position.x + 0.01f * 0.1f, MoveAround.transform.position.y, MoveAround.transform.position.z);
                Res.text = "Left";
            }

     

    }
}
