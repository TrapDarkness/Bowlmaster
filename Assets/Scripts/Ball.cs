using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rigidBody;
    public Vector3 launchVeloctiy;
    private AudioSource audioSource;

    // Use this for initialization
	void Start ()
    {
        //Init Components
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

        Launch();

    }

    public void Launch()
    {
        rigidBody.velocity = launchVeloctiy ;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
