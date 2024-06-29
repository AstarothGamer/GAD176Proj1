using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    [SerializeField] private float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // basic movement for tank
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.Translate(dir * speed * Time.deltaTime);
    }
}
