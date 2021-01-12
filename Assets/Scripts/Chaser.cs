using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform target;
    public float speed = 7f;
    public float stoppingRange = 1.5f;


    void Update()
    {
        Vector3 displacementFromTarget = target.position - transform.position;
        Vector3 directionToTarget = displacementFromTarget.normalized;
        Vector3 velocity = directionToTarget * speed;

        float distanceToTarget = displacementFromTarget.magnitude;

        if (distanceToTarget > stoppingRange)
        {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
