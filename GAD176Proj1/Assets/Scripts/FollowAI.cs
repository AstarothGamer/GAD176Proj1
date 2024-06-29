using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;


    //Set settings of different enemies
    public virtual void EnemySettings()
    {
        
    }

    //Find player in the start of game 
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }

    void Update()
    {
        var dir = target.position - transform.position;

        transform.up = Vector3.MoveTowards(transform.up, dir, rotationSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, moveSpeed * Time.deltaTime);

        ContactAction();
    }

    //action when enemy near enough to player
    public virtual void ContactAction()
    {
        if (Vector3.Distance(transform.position, target.position) <= 3)
        {
            Destroy(gameObject);
        }
    }
}
