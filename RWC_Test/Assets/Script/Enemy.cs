using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool Death = false;
    public bool Shot = false;
    public int Health = 100;

    public void Start()
    {
    }

    private void Update()
    {
        if (Shot)
        {
            Health -= 10;
            Shot = false;
        }
    }

    public void dealDamage(int damage)
    {
        Health -= 10;
    }
}