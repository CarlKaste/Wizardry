using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTutorialTrigger : MonoBehaviour
{
    [SerializeField] private GameObject secondTutorialCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            secondTutorialCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            secondTutorialCanvas.SetActive(false);
        }
    }
}
