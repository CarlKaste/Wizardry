using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private int randomNumber;

    [SerializeField] private int enemyCount;
    [SerializeField] private float enemySpeed;

    [SerializeField] private Rigidbody targetPrefab;

    [SerializeField] private Transform spawner1;
    [SerializeField] private Transform spawner2;
    [SerializeField] private Transform spawner3;

    private void Start()
    {
        StartCoroutine(SpawnerCoroutine(targetPrefab));
    }

    IEnumerator SpawnerCoroutine(Rigidbody enemy)
    {
        yield return new WaitForSeconds(5f);

        while (enemyCount >= 0)
        {
            randomNumber = Random.Range(1, 4);

            if (randomNumber == 1)
            {
                enemy = Instantiate(targetPrefab, spawner1.position, spawner1.rotation) as Rigidbody;
                enemy.AddForce(spawner1.forward * enemySpeed);
            }

            else if (randomNumber == 2)
            {
                enemy = Instantiate(targetPrefab, spawner2.position, spawner2.rotation) as Rigidbody;
                enemy.AddForce(spawner2.forward * enemySpeed);
            }
                
            else if (randomNumber == 3)
            {
                enemy = Instantiate(targetPrefab, spawner3.position, spawner3.rotation) as Rigidbody;
                enemy.AddForce(spawner3.forward * enemySpeed);
            }
                
            enemyCount--;

            yield return new WaitForSeconds(2f);
            yield return null;
        }
        StopAllCoroutines();
    }
}
