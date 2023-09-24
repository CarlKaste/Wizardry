using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private GameObject electricEffect;
    [SerializeField] private Animator targetAnimator;
    [SerializeField] private UnityEvent scoreEvent;

    private Vector3 projectilePosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            StartCoroutine(TargetCoroutine());
            scoreEvent.Invoke();
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

        Destroy(this.gameObject);

        yield return null;
    }
}
