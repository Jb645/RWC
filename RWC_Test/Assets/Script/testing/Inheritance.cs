using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Classes, Abstract Classes, Interfaces, Structs
 */

//Inheritance
//Parent class passess its to its child

//animal Example

/*
public abstract class Parent
{
    public int potato2 = 200;
    protected int potato = 100;
    

    //Animals
    public virtual void Roar()
    {
        Debug.Log(potato2);
    }

    public virtual void setUp()
    {
        Debug.Log("Default");
    }
}



public partial class Child: Parent
{

    public override void setUp()
    {
        Debug.Log(potato2);
        Debug.Log(potato);
        Roar();
    }

    public override void Roar()
    {
        Debug.Log("ROAR");
    }
}
public partial class Child2 : Parent
{

    public override void setUp()
    {
        potato2 = 300;
        Debug.Log(potato2);
        Debug.Log(potato);
    }
    public override void Roar()
    {
        Debug.Log("mew");
    }
}
*/


//Enemy and Players

/*
public abstract class Entities{

    protected int Health;
    protected int damage;
    protected string name;

    

    public virtual void dealDamage(int damage)
    {
    }

    public void get()
    {
        Debug.Log($"Entity: {name} \nHealth: {Health} \nDamage: {damage}");
    }
}

public class Player : Entities
{
    

    public Player(string name)
    {
        Health = 100;
        damage = 20;
        this.name = name;
    }

    public override void dealDamage(int damage)
    {
        //code that deals damage to the enemy
    }
}

public class Enemy2: Entities
{

    public Enemy2(string name)
    {
        Health = 50;
        damage = 10;
        this.name = name;
    }

    public override void dealDamage(int damage)
    {
        //code that deals damage to the player
    }
}
*/


//Interfaces tell you what to do
//Interfaces do not support variables
//do not implement code in functions
//you can only have signatures (i.e scope type name();)
//  --scope - public, private(cannot be in an interface), protected
//  --void, bool, int, string
//signatures must have the same scope and type

/*
interface Iinterface
{
    public void debug();
}
*/

/*
struct Player{
    public int health;
    public int damage;
    private int name;
    public void get()
    {
        
    }
}
*/
public class Inheritance : MonoBehaviour
{
    private void Awake()
    {
        
        /*
        Child lion = new Child();  //initialization of a class (initialization is 'ClassName customName = new ClassName();'
        lion.Roar();
        Child2 cat = new Child2();
        cat.Roar();
        */

        /*
        Player nico = new Player("nico");
        nico.get();
        Enemy2 bobTheHeartless = new Enemy2("Bob The Heartless");
        bobTheHeartless.get();
        nico.get();
        */
    }

    /*
    public void debug()
    {

    }
    */

    //Player bobTheWise; //referenced but not initialized (not new keyword)

    private void Start()
    {
        //bobTheWise.health = 100; //structs don't need to be iniatialized
        
    }

}
