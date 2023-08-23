using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveEvent : MonoBehaviour
{
    [SerializeField] AudioSource doorSound;
    [SerializeField] AudioSource caveSound;
    [SerializeField] AudioSource voiceSound;


    private void Start()
    {
        StartCaveSounds();
    }

    public void StartCaveSounds()
    {
        StartCoroutine(SoundSequenceCoroutine());
    }

    public IEnumerator SoundSequenceCoroutine()
    {
        doorSound.Play();
        yield return new WaitForSeconds(1);
        caveSound.Play();
        yield return new WaitForSeconds(7);
        voiceSound.Play();
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
