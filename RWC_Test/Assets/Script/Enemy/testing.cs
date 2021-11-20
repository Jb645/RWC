using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    
    private void Start()
    {
        Debug.Log("Starting");
        DamagePopup.Create(Vector3.zero, 20);
    }
}
