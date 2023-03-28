using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    //[SerializeField] private EnemySpawner enemySpawner;
    [SerializeField] private SpawnerTimer spawnerTimer;
    [SerializeField] private TargetSpawner targetSpawner;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer.StartTimer();
            //enemySpawner.ActivateSpawner();
            targetSpawner.StartWave1();

            this.gameObject.SetActive(false);
        }
    }
}
