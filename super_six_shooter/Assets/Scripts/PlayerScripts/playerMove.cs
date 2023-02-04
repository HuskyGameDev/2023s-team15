using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public playerController controller;

    [SerializeField] public float runSpeed = 40f;
    [SerializeField] public float jumpSpeed = 50f;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; //Assign direction of movement * speed
	verticalMove = Input.GetAxisRaw("Jump") * jumpSpeed; //Assign direction of movement * speed
    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime);
	controller.Jump(verticalMove * Time.fixedDeltaTime);
    }
}
