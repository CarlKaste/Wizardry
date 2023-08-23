using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudio;

    public void ActivateDoor()
    {
        StartCoroutine(DoorActivationCoroutine());
    }

    public IEnumerator DoorActivationCoroutine()
    {
        buttonAudio.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
