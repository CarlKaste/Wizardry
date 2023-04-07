using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdTutorialTrigger : MonoBehaviour
{
    [SerializeField] private GameObject thirdTutorialCanvas;
    [SerializeField] private GameObject firstTestTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thirdTutorialCanvas.SetActive(true);
            firstTestTrigger.SetActive(true);
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
