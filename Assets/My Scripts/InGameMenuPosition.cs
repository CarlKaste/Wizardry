using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuPosition : MonoBehaviour
{
    [SerializeField] Vector3 firstPosition = new Vector3();
    [SerializeField] Vector3 secondPosition = new Vector3();
    [SerializeField] Vector3 lastPosition = new Vector3();

    private void Start()
    {
        transform.position = lastPosition;
    }

    public void SwitchToFirstPosition()
    {
        transform.position = firstPosition;
    }

    public void SwitchToSecondPosition()
    {
        transform.position = secondPosition;
    }

    public void SwitchToLastposition()
    {
        transform.position = lastPosition;
    }
}
