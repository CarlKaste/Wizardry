using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer2;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private Animator secondFenceAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer2.StartTimer();
            targetSpawner.StartWave2();
            secondFenceAnimator.SetTrigger("OpenFenceGate");
        }
    }
}
