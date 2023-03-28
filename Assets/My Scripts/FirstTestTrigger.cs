using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer1;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private TargetTrigger targetTriggerFirstWave;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer1.StartTimer();
            targetTriggerFirstWave.gameObject.SetActive(true);
            targetSpawner.StartWave1();
        }
    }
}
