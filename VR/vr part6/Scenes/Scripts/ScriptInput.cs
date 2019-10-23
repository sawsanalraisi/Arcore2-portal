using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScriptInput : MonoBehaviour
{
   // public Text result;
   // public GameObject TopBox;

    public float moveSpeed = 0.5f;
    public float scrollSpeed = 10f;
      
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


       

        /*
        if (OVRInput.GetUp(OVRInput.Button.Start))
        {
            result.text = "A || B || X || Y";
            TopBox.transform.Rotate(1f, 1f, 1f);
           // TopBox.transform.position = new Vector3(TopBox.transform.position.x, TopBox.transform.position.y, TopBox.transform.position.z);
        }

        if (OVRInput.GetUp(OVRInput.Button.One) || OVRInput.GetUp(OVRInput.Button.Two) || OVRInput.GetUp(OVRInput.Button.Three) || OVRInput.GetUp(OVRInput.Button.Four))
        {
            result.text = "A || B || X || Y";
            TopBox.transform.Rotate(2f, 2f, 2f);

        }

        if (OVRInput.GetUp(OVRInput.Button.DpadUp) || OVRInput.GetUp(OVRInput.Button.DpadDown) || OVRInput.GetUp(OVRInput.Button.DpadRight) || OVRInput.GetUp(OVRInput.Button.DpadLeft))
        {
            result.text = "DpadUp || DpadDown || DpadRight|| DpadLeft";
            TopBox.transform.Rotate(3f, 3f, 3f);

        }

        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
        {
            TopBox.transform.Rotate(4f, 4f, 4f);
            result.text = "PrimaryHandTrigger";
        }

        if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            result.text = "SecondaryHandTrigger";
            TopBox.transform.Rotate(5f, 5f, 5f);

        }

        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        {
            result.text = "PrimaryHandTrigger";
            TopBox.transform.Rotate(6f, 6f, 6f);

        }

        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
           result.text = "SecondaryHandTrigger";
            TopBox.transform.Rotate(7f, 7f, 7f);

        }

        */


        /*
         // returns true if the primary button (typically “A”) is currently pressed.
OVRInput.Get(OVRInput.Button.One);

// returns true if the primary button (typically “A”) was pressed this frame.
OVRInput.GetDown(OVRInput.Button.One);

// returns true if the “X” button was released this frame.
OVRInput.GetUp(OVRInput.RawButton.X);

// returns a Vector2 of the primary (typically the Left) thumbstick’s current state.
// (X/Y range of -1.0f to 1.0f)
OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

// returns true if the primary thumbstick is currently pressed (clicked as a button)
OVRInput.Get(OVRInput.Button.PrimaryThumbstick);

// returns true if the primary thumbstick has been moved upwards more than halfway.
// (Up/Down/Left/Right - Interpret the thumbstick as a D-pad).
OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp);

// returns a float of the secondary (typically the Right) index finger trigger’s current state.
// (range of 0.0f to 1.0f)
OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);

// returns a float of the left index finger trigger’s current state.
// (range of 0.0f to 1.0f)
OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);

// returns true if the left index finger trigger has been pressed more than halfway.
// (Interpret the trigger as a button).
OVRInput.Get(OVRInput.RawButton.LIndexTrigger);

// returns true if the secondary gamepad button, typically “B”, is currently touched by the user.
OVRInput.Get(OVRInput.Touch.Two);


         */



    }




    public void ClickBtn()
    {

        //result.text = "click_Btn";

    }
}