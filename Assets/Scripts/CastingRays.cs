using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingRays : MonoBehaviour
{
    public static float distanceFromTarget;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit))
        {
            distance = hit.distance;
            distanceFromTarget = distance;
        }
    }
}
