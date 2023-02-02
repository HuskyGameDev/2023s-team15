using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    private Vector3 m_Velocity = Vector3.zero;

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

        //Jump capabilities could potentially go here
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
