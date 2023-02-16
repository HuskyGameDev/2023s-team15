using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private double hp = 3;
    private BoxCollider2D boxColl;
    
    
    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "TempfBullet(Clone)")
        {
            hp = hp - .5;
            if(hp == 0)
            {
            Destroy(gameObject);
            }
        }
    }
}
