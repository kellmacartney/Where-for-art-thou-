using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform spawnPoint;

    int EnemyGenerator;
    public int StartWait;

    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;

    public bool isSpawning = true;



    // Use this for initialization
    void Start()
    {
        
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnWait = Random.Range(SpawnLeastWait, SpawnMostWait);
    }

    IEnumerator Spawner()
    {// function to generate random enemy spawning within a set area
        yield return new WaitForSeconds(StartWait);

      
        if(isSpawning)
        {
            EnemyGenerator = Random.Range(0, Enemies.Length);
             Instantiate(Enemies[EnemyGenerator], spawnPoint.position, gameObject.transform.rotation);

        }
        StartCoroutine(Spawner());
    }
}
