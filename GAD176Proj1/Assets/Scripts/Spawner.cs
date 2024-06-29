using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject octopusPrefab;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 2)
        {
            Vector3 randomSpot = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 6f), 0);
            Instantiate(octopusPrefab, randomSpot, Quaternion.identity);
            timer = 0;
        }
    }
}
