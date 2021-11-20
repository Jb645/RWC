using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Entity", menuName ="Entity")]
public class Entity : ScriptableObject
{
    public new string name;

    public string description;

    public int health;

    public int attack;

    public Sprite artwork;
}
