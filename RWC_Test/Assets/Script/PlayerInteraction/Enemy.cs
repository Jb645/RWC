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
    [SerializeField] private GameObject damagePopUp; 

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
        //added
        ShowDamage(damage.ToString());

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
    //Added
    public void ShowDamage(string text)
    {
        if (damagePopUp)
        {
            Vector3 editedTransform = transform.position;
            editedTransform.x += .1f;
            editedTransform.y += .5f;
            //store instantiated prefab
            GameObject prefab = Instantiate(damagePopUp, editedTransform, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = text;
        }
        
    }
}