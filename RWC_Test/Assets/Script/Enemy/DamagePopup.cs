using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    
    public static DamagePopup Create(Vector3 position, int damageAmount)
    {
        
        Transform damagePopTransform = Instantiate(GameAssets.i.pfDamagePopup, position, Quaternion.identity);
        
        
        DamagePopup damagePopup = damagePopTransform.GetComponent<DamagePopup>();
        damagePopup.Setup(damageAmount);

        return damagePopup;
    }
    public TextMeshPro textMesh;

    private void Awake()
    {
        textMesh = transform.GetComponent<TextMeshPro>();
    }

    public void Setup(int damageAmount)
    {
        textMesh.SetText(damageAmount.ToString());
    }

}
