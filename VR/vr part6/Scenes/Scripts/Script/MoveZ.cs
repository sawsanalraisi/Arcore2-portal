using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZ : MonoBehaviour
{
    public float Speed=0.5f;
    public bool IsMove = true;
   // public Transform target;

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

            
                //transform.Rotate(0, 0, 45f);
            
        }

        //if (transform.position = new Vector3(4.2014,0170002,0.0009f)){IsMove = false;        }



    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "personEnterBuildTag")
        {

            transform.Rotate(0, -45f, 0);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            // Vector3 targetDir = target.position - transform.position;
            //float angle = Vector3.Angle(targetDir, transform.forward);


            // transform.forward = Vector3.RotateTowards(transform.forward, Build.position, Time.deltaTime * 2, 0);

            //IsMove = false;
            //  transform.forward = new Vector3(0, 0, 0);
            // transform.forward = Vector3.RotateTowards(transform.forward, Build, Time.deltaTime * 2, 0);
            // transform.position = new Vector3(transform.position.x + 10f * Time.deltaTime, transform.position.y, transform.position.z - 0.1f * Time.deltaTime);
        }

        if (other.tag== "BuildTag")
        {
            IsMove = false;
        }

       
    }



}
