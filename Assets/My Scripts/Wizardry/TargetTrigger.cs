using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    [SerializeField] private Animator firstFenceAnimator;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Aktiv");

        if (other.CompareTag("Target"))
        {
            Debug.Log("Target Aktiv");
            this.gameObject.SetActive(false);
            firstFenceAnimator.SetTrigger("OpenFenceGate");
        }
    }
}
