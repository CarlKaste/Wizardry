using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float score;

    private void AddScore()
    {
        score = score + 100f;
    }
}
