using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{

    public Text CodeTest;

    
    public void Start()
    {
       // IsShowBorder = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BuildInfoTag")
        {
            CodeTest.text = "CodeTest";
        }

    }

    

}
