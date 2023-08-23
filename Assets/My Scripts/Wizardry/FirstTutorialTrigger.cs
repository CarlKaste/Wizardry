using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTutorialTrigger : MonoBehaviour
{
    [SerializeField] private GameObject firstTutorialCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            firstTutorialCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            firstTutorialCanvas.SetActive(false);
        }
    }
}
