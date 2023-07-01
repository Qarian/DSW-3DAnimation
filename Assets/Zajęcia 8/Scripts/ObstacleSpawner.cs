using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    public float maxHeight;
    public float minHeight;

    public float distance;

    public float speed;

    public float lastObstaclePosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        CreateObstacle();
        CreateObstacle();
        CreateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void CreateObstacle()
    {
        Instantiate(obstacle, new Vector3(lastObstaclePosition, Random.Range(minHeight, maxHeight), 0), Quaternion.identity, transform);
        lastObstaclePosition += distance;
    }
}
