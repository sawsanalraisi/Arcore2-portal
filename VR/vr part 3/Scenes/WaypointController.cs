﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour {

   

    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.1f; //If the distance between the enemy and the waypoint is less than this, then it has reacehd the waypoint
    private int lastWaypointIndex;
   // private float movementSpeed = 5.0f;
    private float movementSpeed = 0.1f;
    private float rotationSpeed = 2.0f;
   // public bool IsMoveRobot = true;

    //Robot
   public GameObject Robot;//once
  //  public bool OnceTimeDone = true;


    //  public GameObject []Dirty;

    //Create Dirty at speific time 
    //[SerializeField] Transform Dirty;
    // float DirtyTimer = 30;


    // Use this for initialization
    void Start () {
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoint = waypoints[targetWaypointIndex]; //Set the first target waypoint at the start so the enemy starts moving towards a waypoint
   
    
      }




    // Update is called once per frame
  public void Update()
    {
      
      /*  DirtyTimer -= Time.deltaTime;
        if (DirtyTimer <= 0)
        {
            // Instantiate(Dirty, new Vector3(Random.Range(-9f,9f), 0.5f, Random.Range(17f, 6f)), Dirty.transform.rotation);
             DirtyTimer = 30;
             Instantiate(Dirty, waypoints[targetWaypointIndex].transform.position, Dirty.transform.rotation);

            //Dirty.gameObject.SetActive(true);
            //rand = Random.Range(0, waypoints.Length);

        }
        */


      float movementStep = movementSpeed * Time.deltaTime;
            //float rotationStep = rotationSpeed * Time.deltaTime;

            //Vector3 directionToTarget = targetWaypoint.position - transform.position;
            Vector3 directionToTarget = targetWaypoint.position - Robot.transform.position;

            Quaternion rotationToTarget = Quaternion.LookRotation(directionToTarget);

            //transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarget, rotationStep); 

            /*
            transform.rotation = rotationToTarget;
            Debug.DrawRay(transform.position, transform.forward * 50f, Color.green, 0f); //Draws a ray forward in the direction the enemy is facing
            Debug.DrawRay(transform.position, directionToTarget, Color.red, 0f); //Draws a ray in the direction of the current target waypoint

            float distance = Vector3.Distance(transform.position, targetWaypoint.position);
            CheckDistanceToWaypoint(distance);

            transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, movementStep);
            */

            Debug.DrawRay(Robot.transform.position, Robot.transform.forward * 50f, Color.green, 0f); //Draws a ray forward in the direction the enemy is facing
            Debug.DrawRay(Robot.transform.position, directionToTarget, Color.red, 0f); //Draws a ray in the direction of the current target waypoint

            float distance = Vector3.Distance(Robot.transform.position, targetWaypoint.position);
            CheckDistanceToWaypoint(distance);

            Robot.transform.position = Vector3.MoveTowards(Robot.transform.position, targetWaypoint.position, movementStep);



        






    }

    /// <summary>
    /// Checks to see if the enemy is within distance of the waypoint. If it is, it called the UpdateTargetWaypoint function 
    /// </summary>
    /// <param name="currentDistance">The enemys current distance from the waypoint</param>
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            targetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }

    /// <summary>
    /// Increaes the index of the target waypoint. If the enemy has reached the last waypoint in the waypoints list, it resets the targetWaypointIndex to the first waypoint in the list (causes the enemy to loop)
    /// </summary>
    void UpdateTargetWaypoint()
    {
        if (targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;

            if (Robot.name == "Robot_clearner_Body")
            {
               // IsMoveRobot = true;
            }


        }

        targetWaypoint = waypoints[targetWaypointIndex];


    
    }

    /*  IEnumerator StopMoveCar()
    {
        yield return new WaitForSeconds(1f);
        IsMoveRobot = false;
        yield return new WaitForSeconds(5f);
        IsMoveRobot = true;
    }*/




}