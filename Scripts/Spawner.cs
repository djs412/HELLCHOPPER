using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float spawnRate = 2.0f;
    private float spawnTimer;
    public GameObject demon;
    private Vector2 vect;
    

    void Start()
    {
        spawnTimer = spawnRate;
        vect.x = 0;
        vect.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Instantiate(demon, vect, Quaternion.identity);
            Debug.Log("Demon spawned");
            spawnTimer = spawnRate;
        }
        
    }
}
