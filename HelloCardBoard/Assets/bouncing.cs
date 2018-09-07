using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour {

    public float moveSpeed = 10f;

    private Rigidbody rbody;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //float inputX = Input.GetAxis("Horizontal");
        //float inputY = Input.GetAxis("Jump");
        //float inputZ = Input.GetAxis("Vertical");

        //float moveX = inputX * moveSpeed * Time.deltaTime;
        //float moveY = inputY * moveSpeed * Time.deltaTime;
        //float moveZ = inputZ * moveSpeed * Time.deltaTime;

        //transform.Translate(moveX, 0f, moveZ);
        transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);

        //rbody.AddForce(moveX, moveY, moveZ);

    }
}
