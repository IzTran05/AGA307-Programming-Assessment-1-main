using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public enum EnemySize
{
    King, Knight, Baby
}

public class EnemyManager : Singleton<EnemyManager>
   
{
    public Transform[] spawnPoints;
    public GameObject[] enemyTypes;
    public List<GameObject> enemies;
    [SerializeField]
    private int spawnCount;
    public Transform GetRandomSpawnPoint => spawnPoints[Random.Range(0, spawnPoints.Length)];
    void Start()
    {


        for(int i = 0; i < 101; i++)
        {
            print(i);
        }
    

        for (int i = 0; i < spawnCount; i++)
        {
            SpawnEnemy();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {

        int rndEnemy = Random.Range(0, enemyTypes.Length);
        int rndSpawnPoint = Random.Range(0, spawnPoints.Length);
        GameObject enemy = Instantiate(enemyTypes[rndEnemy], spawnPoints[rndSpawnPoint].position, spawnPoints[rndSpawnPoint].rotation);
        enemy.GetComponent<Enemy>().Initialize(GetRandomSpawnPoint, enemy.name);
        enemies.Add(enemy);

        print("Enemy Count: " + enemies.Count);
    }


    

}
