using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer1;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private Animator firstFenceAnimator;
    [SerializeField] private InGameMenuPosition scoreCounterMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer1.StartTimer();
            targetSpawner.StartWave1();
            firstFenceAnimator.SetTrigger("OpenFenceGate");
            scoreCounterMenu.SwitchToFirstPosition();
        }
    }
}
