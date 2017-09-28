using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody playerRigidBody;

    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    //Physics code
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        playerRigidBody.AddForce(movement * speed);
    }
}
