using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleGateTrigger : MonoBehaviour
{
    [SerializeField] private GameObject finalTutorialCanvas;
    [SerializeField] private Animator gateAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finalTutorialCanvas.SetActive(true);
            gateAnimator.SetTrigger("OpenGate");
        }
    }
}
