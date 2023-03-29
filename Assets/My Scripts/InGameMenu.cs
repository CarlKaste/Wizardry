using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    private bool isActive;

    public void ActivateMenu()
    {
        isActive = !isActive;

        if (isActive == false)
        {
            this.gameObject.SetActive(true);
        }

        if (isActive == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}