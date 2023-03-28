using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasteGateTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.EndGame();
        }
    }
}
