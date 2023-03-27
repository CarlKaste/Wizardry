using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int randomNumber;
    private float addedEnemyCount;

    private int[] enemySpawnerNumber;
    private List<Transform> enemySpawners = new List<Transform>();

    [SerializeField] private float enemyCount;
    [SerializeField] private float enemySpeed;

    [SerializeField] private GameObject portalTrigger;

    [SerializeField] private Rigidbody targetPrefab;

    [SerializeField] private Transform spawner1;
    [SerializeField] private Transform spawner2;
    [SerializeField] private Transform spawner3;

    private void Awake()
    {
        addedEnemyCount = enemyCount;

        enemySpawners.Add(spawner1);
        enemySpawners.Add(spawner2);
        enemySpawners.Add(spawner3);

        Debug.Log("Start");
    }

    public void ActivateSpawner()
    {/*
        for (int i = 0; i < enemyCount; i++)
        {
            randomNumber = Random.Range(0, 3);
            enemySpawnerNumber[i] = randomNumber;
            Debug.Log("ActivateSpawner 'randomNumber' " + randomNumber);
            Debug.Log("ActivateSpawner 'enemySpawnerNumber' " + enemySpawnerNumber[i]);
        }
        */
        StartCoroutine(SpawnerCoroutine());
    }

    public void TestSpawn()
    {
        randomNumber = Random.Range(0, 3);
        int spawnNumber = randomNumber;
        Rigidbody enemy = Instantiate(targetPrefab, enemySpawners[spawnNumber].position, enemySpawners[spawnNumber].rotation);
        enemy.AddForce(enemySpawners[spawnNumber].forward * enemySpeed);

        /*
        randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {
            Rigidbody e = Instantiate(targetPrefab, spawner1.position, spawner1.rotation);
            e.AddForce(spawner1.forward * enemySpeed);
        }

        if (randomNumber == 2)
        {
            Rigidbody e = Instantiate(targetPrefab, spawner2.position, spawner2.rotation);
            e.AddForce(spawner2.forward * enemySpeed);
        }

        if (randomNumber == 3)
        {
            Rigidbody e = Instantiate(targetPrefab, spawner3.position, spawner3.rotation);
            e.AddForce(spawner3.forward * enemySpeed);
        }
        */
    }

    IEnumerator SpawnerCoroutine()
    {
        yield return new WaitForSeconds(5f);

        while (enemyCount > 0)
        {
            for (int i = 0; i < addedEnemyCount; i++)
            {
                randomNumber = Random.Range(0, 3);
                enemySpawnerNumber[i] = randomNumber;
                Debug.Log("ActivateSpawner 'randomNumber' " + randomNumber);
                Debug.Log("ActivateSpawner 'enemySpawnerNumber' " + enemySpawnerNumber[i]);
                int spawnNumber = enemySpawnerNumber[i];
                Rigidbody enemy = Instantiate(targetPrefab, enemySpawners[spawnNumber].position, enemySpawners[spawnNumber].rotation);
                enemy.AddForce(enemySpawners[spawnNumber].forward * enemySpeed);
                Debug.Log("SpawnerCoroutine 'spawnNumber' " + spawnNumber);
            }
/*
            if (randomNumber == 1)
            {
                Rigidbody enemy = Instantiate(targetPrefab, spawner1.position, spawner1.rotation);
                enemy.AddForce(spawner1.forward * enemySpeed);
            }

            if (randomNumber == 2)
            {
                Rigidbody enemy = Instantiate(targetPrefab, spawner2.position, spawner2.rotation);
                enemy.AddForce(spawner2.forward * enemySpeed);
            }

            if (randomNumber == 3)
            {
                Rigidbody enemy = Instantiate(targetPrefab, spawner3.position, spawner3.rotation);
                enemy.AddForce(spawner3.forward * enemySpeed);
            }
*/
            enemyCount--;

            yield return new WaitForSeconds(3f);
            yield return null;
        }
        enemyCount = addedEnemyCount;

        //StopCoroutine("SpawnerCoroutine");
    }
}
