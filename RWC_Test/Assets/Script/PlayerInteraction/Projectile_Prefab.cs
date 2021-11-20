using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Prefab : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null) //if enemy is not null (doesn't have anything)
        {
            enemy.dealDamage(10);
        }
        Destroy(gameObject);
    }
}