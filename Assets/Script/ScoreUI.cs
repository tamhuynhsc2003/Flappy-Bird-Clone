using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    private void OnEnable()
    {
        // ??ng k� s? ki?n
        ScoreManager.OnScoreChanged += UpdateScoreUI;
    }

    private void OnDisable()
    {
        // H?y ??ng k� s? ki?n ?? tr�nh r� r? b? nh?
        ScoreManager.OnScoreChanged -= UpdateScoreUI;
    }

    private void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Score: " + newScore.ToString();
    }
}
