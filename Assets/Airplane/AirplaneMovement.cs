using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour

{
    public Transform[] waypoints;
    public float moveSpeed = 5.0f;
    private int waypointIndex = 0;

    void Start()
    {
        if (waypoints.Length == 0)
        {
            Debug.LogError("No waypoints assigned to the path.");
            enabled = false; // Disable the script if no waypoints are assigned.
        }
    }

    void Update()
    {
        if (waypointIndex < waypoints.Length)
        {
            Vector3 targetPosition = waypoints[waypointIndex].position;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Rotate towards the target waypoint (optional).
            Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10 * Time.deltaTime);

            // Check if we have reached the current waypoint.
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                waypointIndex = (waypointIndex + 1) % waypoints.Length; // Loop through the waypoints.
            }
        }
    }
}
