using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterControler : MonoBehaviour
{
    private Rigidbody2D body;

    private float horizontal, vertical;

    public float runspeed = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runspeed, vertical * runspeed);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stay trigger");
    }
}