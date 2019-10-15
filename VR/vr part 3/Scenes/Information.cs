using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{

    public Text ShowInfo;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BuildInfoTag")
        {
            ShowInfo.text = "BuildInfoTag";
        }

    }



}
