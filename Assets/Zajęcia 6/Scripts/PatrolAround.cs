using System.Collections.Generic;
using UnityEngine;

public class PatrolAround : MonoBehaviour
{
    public float speed = 3;

    public List<Transform> targets;

    int currentIndex = 0;

    void Update()
    {
        Vector2 ownPosition = transform.position;
        Vector2 targetPosition = targets[currentIndex].position;

        Vector2 distance = targetPosition - ownPosition;
        transform.up = distance.normalized;

        if (distance.magnitude > 0.1f)
        {
            transform.Translate(distance.normalized * Time.deltaTime * speed, Space.World);
        }
        else
        {
            currentIndex++;
            currentIndex %= targets.Count;
        }
    }
}