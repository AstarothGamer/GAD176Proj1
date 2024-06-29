using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : FollowAI
{
    [SerializeField] private GameObject explodePrefab;

    public override void EnemySettings()
    {
        moveSpeed = 4f;
        rotationSpeed = 6f;
    }

    public override void ContactAction()
    {
        Instantiate(explodePrefab, transform.position, Quaternion.Euler(90,0,0));
        Destroy(gameObject);
    }
}
