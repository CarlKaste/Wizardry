using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger2ndWave : MonoBehaviour
{
    [SerializeField] private TargetSpawner targetSpawner;
    [SerializeField] private PortalTrigger3rdWave trigger3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetSpawner.StartWave2();

            this.gameObject.SetActive(false);
        }
    }
}
