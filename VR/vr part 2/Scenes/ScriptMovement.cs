using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovement : MonoBehaviour
{


    public float Timer = 5;
    public GameObject MoveAround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;


        if (Timer <= 0)
        {
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
            {
                MoveAround.transform.position = new Vector3(MoveAround.transform.position.x, MoveAround.transform.position.y, MoveAround.transform.position.z + 1f);
            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
            {
                MoveAround.transform.position = new Vector3(MoveAround.transform.position.x , MoveAround.transform.position.y, MoveAround.transform.position.z - 1f);

            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
            {
                MoveAround.transform.position = new Vector3(MoveAround.transform.position.x + 1f, MoveAround.transform.position.y, MoveAround.transform.position.z);

            }
            if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
            {
                MoveAround.transform.position = new Vector3(MoveAround.transform.position.x + 1f, MoveAround.transform.position.y, MoveAround.transform.position.z);

            }

            Timer = 5;
        }

    }
}
