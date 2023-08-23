using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    //[SerializeField] private EnemySpawner enemySpawner;
    [SerializeField] private SpawnerTimer spawnerTimer;
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private TargetTrigger targetTrigger1;
    [SerializeField] private TargetTrigger2ndWave targetTrigger2;
    [SerializeField] private TargetTrigger3rdWave targetTrigger3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnerTimer.StartTimer();
            //enemySpawner.ActivateSpawner();
            //targetSpawner.StartWave1();
        }
    }
    /*
    private void OnTriggerStay(Collider other)
    {
        if (targetTrigger2.trigger2IsActive == true)
        {
            targetSpawner.StartWave2();
        }

        if (targetTrigger3.trigger3IsActive == true)
        {
            targetSpawner.StartWave3();
        }
    }
    */
}
