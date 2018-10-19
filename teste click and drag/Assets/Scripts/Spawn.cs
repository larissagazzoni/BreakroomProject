using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private float nextSpawnTime;

    [SerializeField]
    private GameObject objectPrefab;
    [SerializeField]
    private float spawnDelay = 15;

    private void Update()
    {
        if (ShouldSpawn ())
        {
            Spawning();
        }
    }

    private void Spawning()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(objectPrefab, transform.position, transform.rotation);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
