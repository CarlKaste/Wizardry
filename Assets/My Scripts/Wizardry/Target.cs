using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private GameObject electricEffect;
    [SerializeField] private Animator targetAnimator;
    [SerializeField] private ScoreCounter scoreCounter;

    private Vector3 projectilePosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            StartCoroutine(TargetCoroutine());
        }
    }

    private IEnumerator TargetCoroutine()
    {
        
        projectilePosition = this.transform.position;
        Instantiate(electricEffect, projectilePosition, Quaternion.identity);

        targetAnimator.SetTrigger("Hit");
        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
        Instantiate(explosionEffect, projectilePosition, Quaternion.identity);

        scoreCounter.AddScore();
        Destroy(this.gameObject);

        yield return null;
    }
}
