using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currenWaypointIndex = 0;

    [SerializeField] private float speed = 2f;
   private void Update()
    {
        if (Vector2.Distance(waypoints[currenWaypointIndex].transform.position, transform.position) < .1f)
        {
            currenWaypointIndex++;
            if(currenWaypointIndex >= waypoints.Length)
            {
                currenWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currenWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
