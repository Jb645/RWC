using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EntityDisplay : MonoBehaviour
{
    public Entity entity;

    public TMP_Text nameText;
    

    public TMP_Text descriptionText;

    public TMP_Text healthText;

    public TMP_Text attackText;

    public Image artwork;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = entity.name;
        healthText.text = $"Health: {entity.health}";
        artwork.sprite = entity.artwork;
    }

    // Update is called once per frame
    void Update()
    {
        entity.health -= 10;
        healthText.text = $"Health: {entity.health}";
    }
}
