using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;

    private void Start()
    {
        ScoreCounter scoreCounter = GetComponent<ScoreCounter>();   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
            scoreCounter.AddScore();
        }
    }
}
