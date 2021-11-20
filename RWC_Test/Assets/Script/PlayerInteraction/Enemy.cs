using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public bool Death = false;
    public bool Shot = false;
    public int Health = 100;
    public HealthBar healthBar;

    public AudioManager AudioManager;
    public SceneSwitch SceneManager;

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
        Health -= damage;
        healthBar.setHealth(Health); //<== changed so it will be modular (add and subtract easily)
        Debug.Log("Enemy Health:" + Health);
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //AudioManager.Play("explosion2");
        //SceneManager.SceneChanger("Animation");
        Destroy(gameObject);
    }
}