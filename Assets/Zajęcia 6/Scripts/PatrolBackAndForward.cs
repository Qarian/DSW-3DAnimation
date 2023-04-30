using System.Collections.Generic;
using UnityEngine;

public class PatrolBackAndForward : MonoBehaviour
{
    public float speed = 3;

    public List<Transform> targets;

    int currentIndex = 0;
    int direction = 1;

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
            currentIndex += direction;
            // Sprawdzenie czy jest na ostatnim punkcie
            if (currentIndex >= targets.Count)
            {
                direction = -direction;
                currentIndex = targets.Count - 2;
            }
            // Sprawdzenie czy jest na początkowym punkcie
            else if (currentIndex < 0)
            {
                direction = -direction;
                currentIndex = 1;
            }
        }
    }
}