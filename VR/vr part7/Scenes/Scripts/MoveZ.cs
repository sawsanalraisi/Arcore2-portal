using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour
{
    public float Speed=0.5f;
    public bool IsMove = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMove == true)
        {
          transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f * Time.deltaTime); 
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "personEnterBuildTag")
        {
           transform.Rotate(0, -45f, 0);
        }

        if (other.tag== "BuildTag")
        {
            IsMove = false;
        }

       
    }



}
