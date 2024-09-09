using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePreFab;
    private GameObject prefab;
    [SerializeField] private GameObject obstaclePreFab2;
    private GameObject prefab2;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private float timeToDespawn;

    private float totalTime;
    private bool spawned = false;

    void Start()
    {
        totalTime = 0;
    }

    void Update()
    {
        totalTime += Time.deltaTime;

        if (totalTime > timeToSpawn && spawned == false)
        {
            // Generar posiciones aleatorias
            float randomPosX1 = Random.Range(-4f, -1f);
            float randomPosX2 = Random.Range(4f, 1f);

            float randomPosY1 = Random.Range(-3f, 3f);


            // Instanciar los objetos en posiciones aleatorias
            prefab = Instantiate(obstaclePreFab, new Vector2(randomPosX1 , randomPosY1), Quaternion.identity);
            prefab2 = Instantiate(obstaclePreFab2, new Vector2(randomPosX2, randomPosY1), Quaternion.identity);

            spawned = true;
            totalTime = 0;
        }

        if (totalTime > timeToDespawn && spawned == true)
        {
            Destroy(prefab); 
            Destroy(prefab2);
            spawned = false;
            totalTime = 0;
        }

        // Debug.Log(totalTime);
    }
}

