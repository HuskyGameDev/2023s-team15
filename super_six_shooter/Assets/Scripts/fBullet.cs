using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
}
