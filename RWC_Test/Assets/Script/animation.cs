using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        MovementKeys(); //ctrl+F12 to get inside function
    }

    private void MovementKeys()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            say("attacking", "AttackAnim");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            say("moving", "moving");
        }
    }

    private void say(string message, string animation)
    {
        Debug.Log(message);
        anim.Play(animation);
    }
}