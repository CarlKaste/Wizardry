using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTutorialTrigger : MonoBehaviour
{
    [SerializeField] private GameObject thirdTutorialCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdTutorialCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdTutorialCanvas.SetActive(false);
        }
    }
}
