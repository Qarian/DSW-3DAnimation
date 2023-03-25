using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        // Mimo tego że Unity pokazuje rotację jako trzy wartości, to pod spodem jest ona zapisywana jako Quaternion
        Debug.Log(GetComponent<Transform>().rotation);

        // Używanie Quaternionów ręcznie nie jest dla ludzi dlatego Unity daje nam możliwość używania Vector3
        GetComponent<Transform>().Rotate(Vector3.right * speed * Time.deltaTime);

        // Vector3 który przedstawia Quaternion nazywa się kątami Eulera
        Debug.Log(GetComponent<Transform>().rotation.eulerAngles);
    }
}
