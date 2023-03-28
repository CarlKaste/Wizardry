using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer3;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private TargetTrigger3rdWave targetTrigger3rdWave;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer3.StartTimer();
            targetTrigger3rdWave.gameObject.SetActive(true);
            targetSpawner.StartWave3();
        }
    }
}
