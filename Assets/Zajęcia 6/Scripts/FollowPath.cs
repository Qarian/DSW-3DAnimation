using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public float speed = 3;

    public List<Transform> targets;

    public int currentIndex = 0;
    public int direction = 1;
    
    void Update()
    {
        // Zatrzymanie na ostanim elemencie
        // Sprawdzanie czy indeks jest mniejszy od zera sprawdza jeżeli idziemy od końca
        if (currentIndex >= targets.Count || currentIndex < 0)
        {
            return;
        }

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
        }
    }
}