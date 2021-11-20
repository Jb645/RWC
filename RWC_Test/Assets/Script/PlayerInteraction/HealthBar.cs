using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public TMP_Text Health;
    private int health = 100;
    public Slider slider;

    //basic initialization
    public void Start()
    {
        Debug.Log("initialized");
        Health.text = health + "%";
        visualChange();
    }

    //setting health
    public void setHealth(int health)
    {
        Health.text = health + "%";
        visualChange(health);
    }

    
    public void visualChange()
    {
        slider.maxValue = health;
        slider.value = health;
    }
    

    public void visualChange(int health)
    {
        slider.value = health;
    }
}