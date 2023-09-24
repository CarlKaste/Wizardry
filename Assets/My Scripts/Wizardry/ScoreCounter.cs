using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private float startingPoints = 0f;

    [SerializeField] private float currentPoints;
    [SerializeField] private float pointsToAdd;
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        currentPoints = startingPoints;
        scoreText.text = currentPoints.ToString();
    }

    private void Update()
    {
        scoreText.text = currentPoints.ToString();
    }

    public void AddScore()
    {
        Debug.Log("Score added!");
        currentPoints += pointsToAdd;
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
