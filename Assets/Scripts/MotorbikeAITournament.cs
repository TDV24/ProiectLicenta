using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MotorbikeAITournament : MonoBehaviour
{
    Vector3 targetPosition = Vector3.zero;
    Waypoint actualWaypoint = null;
    Waypoint[] waypoints;
    MotorbikeControllerTournament motorbikeControllerTournament;
    // Start is called before the first frame update
    private void Awake()
    {
        motorbikeControllerTournament = GetComponent<MotorbikeControllerTournament>();
        waypoints = FindObjectsOfType<Waypoint>();
    }
    void FixedUpdate()
    {
        Vector2 input = Vector2.zero;
        FollowWaypoints();
        input.x = TurnToTarget();
        input.y = AccelOrBrake(input.x);
        motorbikeControllerTournament.SetInputVector(input);
    }
    float TurnToTarget()
    {
        //get the position to make the turn
        Vector2 vectorToTarget = targetPosition - transform.position;
        vectorToTarget.Normalize();

        //find the turn angle
        float angleToTarget = Vector2.SignedAngle(transform.up, vectorToTarget);
        angleToTarget *= -1;

        //find the intensity of the steering
        float steerAmount = angleToTarget / 45.0f;
        steerAmount = Mathf.Clamp(steerAmount, -1.0f, 1.0f);
        return steerAmount;
    }
    void FollowWaypoints()
    {
        if(actualWaypoint == null)
        {
            actualWaypoint = getClosestWaypoint();
        }
        if(actualWaypoint != null)
        {
            targetPosition = actualWaypoint.transform.position;
            float distance = (targetPosition - transform.position).magnitude;
            if(distance <= actualWaypoint.minDistToWaypoint)
            {
                actualWaypoint = actualWaypoint.nextWaypoint[0];
            }
        }
    }
    Waypoint getClosestWaypoint()
    {
        return waypoints
            .OrderBy(x => Vector3.Distance(transform.position, x.transform.position))
            .FirstOrDefault();
    }
    float AccelOrBrake(float x)
    {
        return 1.01f - x / 1.0f;
    }
}
