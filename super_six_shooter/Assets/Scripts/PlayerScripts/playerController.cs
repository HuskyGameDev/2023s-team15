using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    private Vector3 m_Velocity = Vector3.zero;
    private Vector3 m_jumpVelocity = Vector3.zero;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    private void Awake() 
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Move the player
    public void Move(float move)
    {
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
        // And then smoothing it out and applying it to the character
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, .05f);

        //Implementation of "flip sprite" would go here

    }

    //This is a method specifically for jumping
    public void Jump(float move)
    {
	isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
	if(isTouchingGround)
	{
		//Vector3 targetJumpVelocity = new Vector2(m_Rigidbody2D.velocity.x, move * 10f);
		//I tried using this smooth thing, and it made the jumping really floaty.
		//Since I am not using the below line, then I don't need the above line. However, I have left them here just in case I or someone else might need to use them.
		//m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetJumpVelocity, ref m_jumpVelocity, 0f);
		m_Rigidbody2D.velocity = new Vector2(m_Rigidbody2D.velocity.x, move * 10f);//Keeps the smae x velocity, and adds to the y velocity.
	}

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
