using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypoitIndex = 0;

    [SerializeField] private float speed = 2f;
    void Update()
    {
        if(Vector2.Distance(waypoints[currentWaypoitIndex].transform.position, transform.position) < 0.1f)
        {
            currentWaypoitIndex++;
            if(currentWaypoitIndex == waypoints.Length)
            {
                currentWaypoitIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoitIndex].transform.position, Time.deltaTime * speed);
    }
}
