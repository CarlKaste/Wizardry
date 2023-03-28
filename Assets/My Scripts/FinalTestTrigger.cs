using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer3;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private Animator thirdFenceAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer3.StartTimer();
            targetSpawner.StartWave3();
            thirdFenceAnimator.SetTrigger("OpenFenceGate");
        }
    }
}
