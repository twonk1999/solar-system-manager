﻿using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
    private Transform centre; // Variable for centre position of the body that you want the object to orbit.
    [SerializeField]
    private Vector3 axis = new Vector3(0, 1, 0); // Creates a new vector3 variable with values only on the y axis. This is so that the object will by default revolve around the y axis.
    [SerializeField]
    private float radius = 2f; // Adjustable radius variable
    [SerializeField]
    private float orbitSpeed = 60f; // Adjustable orbit speed variable

    void Start()
    {
        transform.position = (transform.position - centre.position).normalized * radius + centre.position; // Moves object into start position relative to the body it is orbiting.
    }

    void FixedUpdate()
    {
        transform.RotateAround(centre.position, axis, orbitSpeed * Time.deltaTime); // Rotates the object around the centre of the body on the y axis by default, with speed of 60 by default.
    }
}
