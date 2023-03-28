using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer2;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private TargetTrigger2ndWave targetTrigger2ndWave;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer2.StartTimer();
            targetTrigger2ndWave.gameObject.SetActive(true);
            targetSpawner.StartWave2();
        }
    }
}
