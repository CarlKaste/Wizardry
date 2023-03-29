using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerTimer : MonoBehaviour
{
    [SerializeField] private Text timerText;

    public void StartTimer()
    {
        StartCoroutine(TimerCoroutine(timerText));
    }

    IEnumerator TimerCoroutine(Text text)
    {
        text.text = "3";
        yield return new WaitForSeconds(1f);
        text.text = "2";
        yield return new WaitForSeconds(1f);
        text.text = "1";
        yield return new WaitForSeconds(1f);
        text.text = "Start";
        yield return new WaitForSeconds(1f);
        text.text = " ";

        yield return null;

        //StopCoroutine("TimerCoroutine");
    }
}
