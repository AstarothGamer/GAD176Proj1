using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float rotationSpeed;

    //Set settings of different enemies
    public virtual void EnemySettings()
    {
        //Custom settings for enemies
    }

    //action when enemy near enough to player
    public virtual void ContactAction()
    {
        //custom actions for enemies
        Destroy(gameObject);
    }

    //Find player in the start of game
    #region Unity Specific Functions
    void Start()
    {
        EnemySettings();
        target = FindObjectOfType<Player>().transform;
    }

    //Move to player 
    void Update()
    {
        var dir = target.position - transform.position;

        transform.up = Vector3.MoveTowards(transform.up, dir, rotationSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 3)
        {
            ContactAction();

        }
    }
    #endregion

}
