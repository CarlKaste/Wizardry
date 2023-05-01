using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody target;
    [SerializeField] private GameObject secondTestTrigger;

    [SerializeField] private int targetCountFirst;
    [SerializeField] private int targetCountSecond;
    [SerializeField] private int targetCountLast;

    private int posX;
    private int posY;
    private int posZ;

    public Rigidbody[] targets;

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

        for (int i = 0; i < targetCountFirst; i++)
        {
            posX = Random.Range(-3, 4);
            posY = Random.Range(5, 9);
            posZ = Random.Range(2, 10);
            targets[i] = Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
        }

        yield return null;
    }    

    IEnumerator TargetSpawn2()
    {
        yield return new WaitForSeconds(5f);

        for (int i = 0; i < targetCountSecond; i++)
        {
            posX = Random.Range(-3, 4);
            posY = Random.Range(5, 9);
            posZ = Random.Range(15, 23);
            targets[i] = Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
        }

        yield return null;
    }    

    IEnumerator TargetSpawn3()
    {
        yield return new WaitForSeconds(5f);

        for (int i = 0; i < targetCountLast; i++)
        {
            posX = Random.Range(-5, 6);
            posY = Random.Range(5, 9);
            posZ = Random.Range(29, 42);
            targets[i] = Instantiate(target, new Vector3(posX, posY, posZ), Quaternion.identity);
        }

        yield return null;
    }
}
