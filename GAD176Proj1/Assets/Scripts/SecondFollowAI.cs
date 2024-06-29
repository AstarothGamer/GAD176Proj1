using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Vector3 normalized;

    float x;
    float y;
    float m;

    //Set settings of different enemies
    public virtual void EnemySettings()
    {

    }

    //action when enemy near enough to player
    public virtual void ContactAction()
    {
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().transform;

    }

    // Update is called once per frame
    void Update()
    {
        //Normalization of vector
        normalized.x = target.position.x - transform.position.x;
        normalized.y = target.position.y - transform.position.y;
        //For 3D games use line below
        // normalized.z = target.position.z - transform.position.z;

        x = normalized.x * normalized.x;
        y = normalized.y * normalized.y;
        //For 3D games use line below
        // normalized.z = normalized.z * normalized.z;

        m = Mathf.Sqrt(x + y);

        normalized.x = normalized.x / m;
        normalized.y = normalized.y / m;
        //For 3D games use line below
        //normalized.z = normalized.z / m;

        //Moving to player
        transform.position += normalized * moveSpeed * Time.deltaTime;


        //Rotation enemy to player
        var dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, -angle);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

        ContactAction();

    }

}
