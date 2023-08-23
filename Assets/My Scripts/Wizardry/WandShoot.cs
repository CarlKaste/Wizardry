using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandShoot : MonoBehaviour
{
    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private Transform magicCastPoint;
    [SerializeField] private float projectileSpeed;

    public void ShootProjectile()
    {
        Rigidbody magicProjectile;
        magicProjectile = Instantiate(projectilePrefab, magicCastPoint.position, magicCastPoint.rotation) as Rigidbody;
        magicProjectile.AddForce(magicCastPoint.up * projectileSpeed);
    }
}
