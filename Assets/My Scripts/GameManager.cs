using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator levelLoaderAnimator;

    public void StartGame()
    {
        StartCoroutine(StartGameCoroutine());
    }

    public void BackToMenu()
    {
        StartCoroutine(BackToMenuCoroutine());
    }

    public void ExitGame()
    {
        StartCoroutine(ExitGameCoroutine());
    }

    private IEnumerator StartGameCoroutine()
    {
        levelLoaderAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        yield return null;
    }

    private IEnumerator BackToMenuCoroutine()
    {
        levelLoaderAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        yield return null;
    }

    private IEnumerator ExitGameCoroutine()
    {
        levelLoaderAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        Application.Quit();

        yield return null;
    }
}
