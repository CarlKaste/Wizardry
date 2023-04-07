using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private GameObject electricEffect;
    [SerializeField] private Animator targetAnimator;

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
        Destroy(this.gameObject);
        Instantiate(explosionEffect, projectilePosition, Quaternion.identity);

        scoreCounter.AddScore();

        yield return null;
    }
}
