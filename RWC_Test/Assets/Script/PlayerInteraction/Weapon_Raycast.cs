using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Raycast : MonoBehaviour
{
    public Transform firePoint;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hitInfo)
        {
            Debug.Log("Hit!");
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            if (enemy != null) //if enemy is not null (doesn't have anything)
            {
                enemy.dealDamage(10);
            }
        }
    }
}