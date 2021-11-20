using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i {
        get
        {
            
            if (_i == null)
            {
                Debug.Log("GameAssets Work");
                
            }
            return _i;
        }
    }


    public Transform pfDamagePopup;

}
