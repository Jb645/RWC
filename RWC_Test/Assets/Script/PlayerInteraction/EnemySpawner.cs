using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Enemy;

    public Spawn[] enemies;

    private void Start()
    {
        foreach (Spawn enemy in enemies)
        {
            Instantiate(Enemy, enemy.point.position, enemy.point.rotation);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}