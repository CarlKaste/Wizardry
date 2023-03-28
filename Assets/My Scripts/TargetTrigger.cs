using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger : MonoBehaviour
{
    [SerializeField] private Animator firstFenceAnimator;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            this.gameObject.SetActive(false);
            firstFenceAnimator.SetTrigger("OpenFenceGate");
        }
    }
}
