using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody target;
    private int posX;
    private int posY;
    private int posZ = 13;
    private int targetCount;

    public bool noMoreTargets = false;

    public void StartWave1()
    {
        StartCoroutine(TargetSpawn1());
    }

    public void StartWave2()
    {
        StartCoroutine(TargetSpawn2());
    }

    public void StartWave3()
    {
        StartCoroutine(TargetSpawn3());
    }

    IEnumerator TargetSpawn1()
    {
        yield return new WaitForSeconds(5f);

        while (targetCount < 3)
        {
            posX = Random.Range(-5, 6);
            posY = Random.Range(1, 9);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;
        }
        yield return null;
    }    

    IEnumerator TargetSpawn2()
    {
        yield return new WaitForSeconds(3f);

        while (targetCount < 5)
        {
            posX = Random.Range(-5, 6);
            posY = Random.Range(1, 9);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;

            
        }
        yield return null;
    }    

    IEnumerator TargetSpawn3()
    {
        yield return new WaitForSeconds(3f);

        while (targetCount < 7)
        {
            posX = Random.Range(-5, 6);
            posY = Random.Range(1, 9);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;
        }

        yield return new WaitForSeconds(1f);
        noMoreTargets = true;

        yield return null;
    }
}
