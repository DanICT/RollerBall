using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Timers;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameController gameController;
    private Rigidbody playerRigidBody;
    private bool isAlive;
    private int count;


    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        this.count = 0;
        this.isAlive = true;
    }

    //Physics code
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (this.isAlive == true)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
            playerRigidBody.AddForce(movement * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.isAlive)
        {
            if (other.gameObject.CompareTag("Pickup"))
            {
                other.gameObject.SetActive(false);
                this.count++;
                this.gameController.updateCountUI(this.count);
                if (this.count == 11)
                {
                    this.gameController.setGameIsWon(true);
                }
            }
            else if (other.gameObject.CompareTag("Wall"))
            {
                this.speed = 0;
                this.isAlive = false;
                this.gameController.setGameIsWon(false);
            }
        }
    }

    public void resetPlayer()
    {
        this.count = 0;
        Vector3 movement = new Vector3(0, 0, 0);
        playerRigidBody.AddForce(movement * 0);
        this.playerRigidBody.MovePosition(new Vector3(0, 0.5f, 0));
        this.speed = 10;
        this.isAlive = true;
    }
}
