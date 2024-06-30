using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : FollowAI
{
    [SerializeField] private GameObject explodePrefab;

    //Set settings for the enemy
    public override void EnemySettings()
    {
        moveSpeed = 4f;
        rotationSpeed = 6f;
    }

    private void Start()
    {
        if (explodePrefab == null)
        {
            Debug.LogError("explodePfefab is null! Please ensure it is assigned in the Inspector or instantiated correctly.");
        }
    }

    //Specific actions for the enemy
    public override void ContactAction()
    {
        Instantiate(explodePrefab, transform.position, Quaternion.Euler(90,0,0));
        Destroy(gameObject);
    }
}
