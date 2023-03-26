using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private float points;

    [SerializeField] private float pointsToAdd;
    [SerializeField] private Text scoreText;

    private void Update()
    {
        int addPoints = (int)points;
        scoreText.text = addPoints.ToString();
    }

    public void AddScore()
    {
        points = points + pointsToAdd;
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
