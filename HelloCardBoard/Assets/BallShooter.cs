using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallShooter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class ExampleClass : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        print("Points colliding: " + other.contacts.Length);
        print("First point that collided: " + other.contacts[0].point);
    }
}
