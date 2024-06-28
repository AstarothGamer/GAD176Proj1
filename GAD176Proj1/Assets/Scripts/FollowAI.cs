using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        var dir = target.position - transform.position;

        transform.up = Vector3.MoveTowards(transform.up, dir, rotationSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, moveSpeed * Time.deltaTime);
    }
}
