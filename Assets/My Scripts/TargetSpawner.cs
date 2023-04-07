using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody target;
    [SerializeField] private GameObject secondTestTrigger;
 
    private int posX;
    private int posY;
    private int posZ;

    private int targetCount;
    private int targetCountStart;

    private void Start()
    {
        targetCountStart = targetCount;
    }

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
            posX = Random.Range(-3, 4);
            posY = Random.Range(5, 9);
            posZ = Random.Range(2, 10);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;
        }

        targetCount = targetCountStart;
        yield return null;
    }    

    IEnumerator TargetSpawn2()
    {
        yield return new WaitForSeconds(5f);

        while (targetCount < 5)
        {
            posX = Random.Range(-3, 4);
            posY = Random.Range(5, 9);
            posZ = Random.Range(15, 23);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;
        }

        targetCount = targetCountStart;
        yield return null;
    }    

    IEnumerator TargetSpawn3()
    {
        yield return new WaitForSeconds(5f);

        while (targetCount < 12)
        {
            posX = Random.Range(-5, 6);
            posY = Random.Range(5, 9);
            posZ = Random.Range(29, 42);
            Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
            targetCount++;
        }

        targetCount = targetCountStart;
        yield return null;
    }
}
