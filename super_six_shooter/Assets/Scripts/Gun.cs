using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fbulletPrefab;

    public Transform MousePoint;

    // Update is called once per frame
    void Update()
    {
        mouseDirection();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            mouseShoot();
        }
    }

    void Shoot()
    {
        Instantiate(fbulletPrefab, firePoint.position, firePoint.rotation);
    }

    void mouseShoot()
    {
        Instantiate(fbulletPrefab, MousePoint.position, MousePoint.rotation);
    }

    void mouseDirection()
    {
        Vector3 input = Input.mousePosition;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(input);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        MousePoint.transform.right = direction;
    }
}
