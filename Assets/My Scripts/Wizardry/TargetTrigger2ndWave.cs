using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger2ndWave : MonoBehaviour
{
    [SerializeField] private Animator secondFenceAnimator;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            this.gameObject.SetActive(false);
            secondFenceAnimator.SetTrigger("OpenFenceGate");
        }
    }
}
