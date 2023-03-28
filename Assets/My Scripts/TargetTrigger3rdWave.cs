using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetTrigger3rdWave : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Animator thirdFenceAnimator;
    [SerializeField] private Animator castleGateAnimator;
    [SerializeField] private GameObject finalTutorialCanvas;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            thirdFenceAnimator.SetTrigger("OpenFenceGate");
            castleGateAnimator.SetTrigger("OpenGate");
            finalTutorialCanvas.SetActive(true);
        }
    }
}
