using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int currentPoints;

    [SerializeField] private int pointsToAdd;
    [SerializeField] private Text scoreText;

    private void Start()
    {
        currentPoints = 0;
        scoreText.text = currentPoints.ToString();
    }

    public void AddScore()
    {
       currentPoints = currentPoints + pointsToAdd;
       scoreText.text = currentPoints.ToString();
    }

    public void ShowScoreBoard()
    {
        gameObject.SetActive(true);
    }

    public void HideScoreBoard()
    {
        gameObject.SetActive(false);
    }
}
