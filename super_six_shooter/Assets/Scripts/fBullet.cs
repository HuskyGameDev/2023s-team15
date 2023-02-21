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
        StartCoroutine(Countdown());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Solid Object")
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator Countdown()
    {
        while(true)
        {
            yield return new WaitForSeconds(3);
            Destroy(gameObject);
        }
    }
}
