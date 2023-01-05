using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] enemies;

    public float timeSpawnEnemies = 0.1f;
    public float repeatSpwanRateEnemies = 2;

    public Transform xRangeLeft;
    public Transform xRangeRight;

    public Transform yRangeUp;
    public Transform yRangeDown;

    public GameObject[] fruits;
    public float timeSpawnFruits = 0.1f;
    public float repeatSqawnRateFruits = 3;

    public float difficultyTime = 0;
    void Start()
    {
        StartCoroutine("EnemyDifficulty");
        StartCoroutine("FruitDifficulty");
    }

    IEnumerator EnemyDifficulty()
    {
        yield return new WaitForSeconds(repeatSpwanRateEnemies);
        SpawnEnemies();
        StartCoroutine("EnemyDifficulty");
    }
    IEnumerator FruitDifficulty()
    {
        yield return new WaitForSeconds(repeatSqawnRateFruits);
        SpawnFruits();
        StartCoroutine("FruitDifficulty");
    }
    private void Update()
    {
        difficultyTime += Time.deltaTime;

        if(difficultyTime>5 && difficultyTime < 10)
        {
            repeatSpwanRateEnemies = 1.5f;
            repeatSqawnRateFruits = 3.5f;
        }
        if (difficultyTime > 10 && difficultyTime < 15)
        {
            repeatSpwanRateEnemies = 1;
            repeatSqawnRateFruits = 4;
        }
        if (difficultyTime > 15 && difficultyTime < 20)
        {
            repeatSpwanRateEnemies = 0.75f;
            
        }
        if (difficultyTime > 20)
        {
            repeatSpwanRateEnemies = 0.25f;
        }
    }

    public void SpawnEnemies()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);
        GameObject enemie = Instantiate(enemies[Random.Range(0,enemies.Length)], spawnPosition, gameObject.transform.rotation);
    }
    public void SpawnFruits()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);
        GameObject enemie = Instantiate(fruits[Random.Range(0, fruits.Length)], spawnPosition, gameObject.transform.rotation);
    }
}
