using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject plane;
    private int maxSpawn;

    public float spawnInterval = 1f;
    public float spawnIncreaseMultiplier = 1;
    public float maxSpawnRate;
    float timeTrack;

    private void Start()
    {
        maxSpawn = spawnPoints.Length - 1;
    }

    private void Update()
    {
        if (Time.time > timeTrack + spawnInterval)
        {
            timeTrack = Time.time + spawnInterval;
            Instantiate(plane, spawnPoints[Random.Range(0, maxSpawn)].transform.position, Quaternion.identity);
            
            if(spawnInterval > maxSpawnRate)
            {
                spawnInterval *= spawnIncreaseMultiplier;
            }
        }
    }
    /*public GameObject spawnAreaStart;
    public GameObject spawnAreaEnd;
    public GameObject planeEnemy;
    public int enemyCount;
    public int totalSpawns;
    public float spawnInterval;
    private float xPos, yPos;


    private void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount < totalSpawns)
        {
            xPos = Random.Range(spawnAreaStart.transform.position.x, spawnAreaEnd.transform.position.x);

            Instantiate(planeEnemy, new Vector3(xPos, spawnAreaStart.transform.position.y, spawnAreaStart.transform.position.z), Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
            enemyCount += 1;
        }
    }*/
}
