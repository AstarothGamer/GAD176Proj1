using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private GameObject octopusPrefab;

    void Start()
    {
        if (octopusPrefab == null)
        {
            Debug.LogError("octopusPrefab is null! Please ensure it is assigned in the Inspector or instantiated correctly.");
        }
    }

    //Random spawner 
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeToSpawn)
        {
            Vector3 randomSpot = new Vector3(Random.Range(-10f, 11f), Random.Range(-5f, 6f), 0);
            Instantiate(octopusPrefab, randomSpot, Quaternion.identity);
            timer = 0;
        }
    }
}
