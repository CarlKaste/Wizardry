using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTestTrigger : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer3;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private Animator thirdFenceAnimator;
    [SerializeField] private InGameMenuPosition scoreCounterMenu;
    [SerializeField] private AudioSource fenceGateSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer3.StartTimer();
            targetSpawner.StartWave3();
            thirdFenceAnimator.SetTrigger("OpenFenceGate");
            fenceGateSound.Play();
            scoreCounterMenu.SwitchToLastposition();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
