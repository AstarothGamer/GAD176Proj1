using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] public int health = 100;
    [SerializeField] private float speed = 1;


    #region Unity Specific Functions
    // basic movement for tank
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.Translate(dir * speed * Time.deltaTime);
    }
    #endregion
}
