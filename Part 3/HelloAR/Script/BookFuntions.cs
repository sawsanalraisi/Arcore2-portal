using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookFuntions : MonoBehaviour
{

    public GameObject BookCamera;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "OpenBookTag")
            {
            BookCamera.SetActive(true);
            }
            
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "OpenBookTag")
        {
            BookCamera.SetActive(false);
        }
    }

}
