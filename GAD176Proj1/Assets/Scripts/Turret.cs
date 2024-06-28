using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float rotatinSpeed;



    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.up = Vector3.MoveTowards(transform.up, mousePosition, rotatinSpeed * Time.deltaTime); ;
    }
}
