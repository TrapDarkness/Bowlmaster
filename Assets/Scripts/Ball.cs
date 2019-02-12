﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public bool inPlay = false;
    private Rigidbody rigidBody;
    public Vector3 launchVelocity;
    private AudioSource audioSource;


    // Use this for initialization
	void Start ()
    {
        rigidBody = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().useGravity = false;

    }

    public void Launch(Vector3 velocity)
    {
        inPlay = true;
        GetComponent<Rigidbody>().useGravity = true;
        rigidBody.velocity = velocity;

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

}



