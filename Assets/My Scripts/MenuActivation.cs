using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActivation : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isActivated == false)
        {
            Debug.Log("Bzz");
            menuCanvas.SetActive(true);
            isActivated = true;
        }

        if (isActivated == true)
        {
            Debug.Log("Bzz");
            menuCanvas.SetActive(false);
            isActivated = false;
        }
    }
}
