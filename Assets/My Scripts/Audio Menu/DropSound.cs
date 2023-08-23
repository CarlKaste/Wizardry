using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}
