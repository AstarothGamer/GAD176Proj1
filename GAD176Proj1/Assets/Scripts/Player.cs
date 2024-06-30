using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] public int health = 100;
    [SerializeField] public float speed = 1;

    // basic movement for tank
    private void Movement()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.Translate(dir * speed * Time.deltaTime);
    }

    #region Unity Specific Functions
    void Update()
    {
        Movement();
    }
    #endregion
}
