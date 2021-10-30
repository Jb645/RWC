using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //var int (numbers), booleans (true, false), strings ""
    //public, private

    //global - everywhere
    public int dan; //132

    private int luigi = 49;
    private int sum;

    public bool harold;

    public string str2 = "dave";
    public string str1 = " harold";

    private enum States
    {
        Start, Playing, Losing
    }

    private States gameplay = States.Start;

    // Start is called before the first frame update
    private void Start()
    {
        /*
        if (dan != luigi || (dan + luigi) <= 500)  //if true is true
        {
            Debug.Log("sum is greater than 500" + " " + (dan + luigi));
        }
        else
        {
            sum = dan + luigi;
            Debug.Log("sum is less than 500" + " " + sum);
        }
        */
        gameplay = States.Playing;

        switch (gameplay)
        {
            case States.Start:
                Debug.Log("Start Screen");
                break;

            case States.Playing:
                Debug.Log("Start Playing");
                break;

            case States.Losing:
                Debug.Log("Start Losing");
                break;
        }

        /*
        //While, and for loop
        while (luigi < 50)
        {
            Debug.Log(luigi + " while");
            luigi++;
        }
        //  i starts at 0,while i < luigi, i increasing 1+
        for (int i = 0; i <= luigi; i++)
        {
            Debug.Log(i);
        }
        */
    }

    // Update is called once per frame
    private void Update() //30fps
    {
    }
}