using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Lists : MonoBehaviour
{
    // Start is called before the first frame update

    //Lists, Queues, Arrays, HashTables, Dictionaries
    //ways to store information
    /*
    ArrayList<int> integers;
    */
    Dictionary<string, int> items;

    public float[] integers; //they all start at 0
    private void Awake()
    {
        /*
        for(int i = 0; i< 10; i++)
        {
            integers.Add(i);
        }

        Debug.Log(integers);
        */
        //items.Add("potato", 20);

        foreach(int number in integers)
        {
            Debug.Log(number);
        }

        
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
