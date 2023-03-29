using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    [SerializeField] private GameObject magicEffect;
    private Vector3 projectilePosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target") || collision.gameObject.CompareTag("Object"))
        {
            projectilePosition = this.transform.position;
            Destroy(this.gameObject);
            Instantiate(magicEffect, projectilePosition, Quaternion.identity);
        }
    }
}
