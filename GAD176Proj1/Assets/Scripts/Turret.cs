using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float rotationSpeed;



    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        var dir = mousePosition - transform.position;
        transform.up = Vector3.MoveTowards(transform.up, dir, rotationSpeed * Time.deltaTime);

    }
}
