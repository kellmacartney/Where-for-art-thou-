using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemies;
    public Vector3 spawnboundaries;

    int EnemyGenerator;
    public int StartWait;

    public float SpawnWait;
    public float SpawnMostWait;
    public float SpawnLeastWait;

    public bool Stop;



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

        while (!Stop)

        {
            EnemyGenerator = Random.Range(0, Enemies.Length);
          //  Vector3 spawnposition = new Vector2(transform.position.x, transform.position.y);
            Vector3 spawnposition = new Vector2(Random.Range(-spawnboundaries.x, spawnboundaries.x), Random.Range(-spawnboundaries.y, spawnboundaries.y));
            Instantiate(Enemies[EnemyGenerator], spawnposition, gameObject.transform.rotation);

            

            yield return new WaitForSeconds(SpawnWait);
        }
    }
}
