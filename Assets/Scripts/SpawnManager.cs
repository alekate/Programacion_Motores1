using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePreFab;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private float timeToDespawn;

    private float totalTime;
    private bool spawned = false;
    private GameObject spawnedObstacle;

    void Start()
    {
        totalTime = 0;
    }

    void Update()
    {
        totalTime += Time.deltaTime;

        if (totalTime > timeToSpawn && spawned == false)
        {
            Instantiate(obstaclePreFab, new Vector2(0, 0), Quaternion.identity);
            spawned = true;
            totalTime = 0;
            spawnedObstacle= obstaclePreFab;
        }

        if (totalTime > timeToDespawn && spawned == true)
        {
            spawnedObstacle = obstaclePreFab;
            Destroy(spawnedObstacle); 
            spawned = false;
            totalTime = 0;
        }

        Debug.Log(totalTime);
    }
}
