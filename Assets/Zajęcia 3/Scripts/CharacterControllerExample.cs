using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerExample : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Character controller combines simple movement as using Transform and collision detection as using Rigidbody.
        // More can be read on https://docs.unity3d.com/ScriptReference/CharacterController.html
        GetComponent<CharacterController>().SimpleMove(
            new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * speed));
    }
}
