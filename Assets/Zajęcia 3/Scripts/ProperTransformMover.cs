using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperTransformMover : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        //Input.GetAxis omówione w InputUsingAxis.cs

        // Poruszanie postacią w 2D (pionowo i poziomo)
        GetComponent<Transform>().Translate(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime,
            0);

        // Poruszanie postacią z kamerą od góry (do przodu/tyłu i na boki)
        /*GetComponent<Transform>().Translate(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            0,
            Input.GetAxis("Vertical") * speed * Time.deltaTime);*/
    }
}
