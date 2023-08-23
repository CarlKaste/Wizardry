using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleGateTrigger : MonoBehaviour
{
    [SerializeField] private GameObject finalTutorialCanvas;
    [SerializeField] private Animator rightGateAnimator;
    [SerializeField] private Animator leftGateAnimator;
    [SerializeField] private AudioSource leftGateSound;
    [SerializeField] private AudioSource rightGateSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finalTutorialCanvas.SetActive(true);
            rightGateAnimator.SetTrigger("OpenRightGate");
            leftGateAnimator.SetTrigger("OpenLeftGate");
            rightGateSound.Play();
            leftGateSound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finalTutorialCanvas.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
