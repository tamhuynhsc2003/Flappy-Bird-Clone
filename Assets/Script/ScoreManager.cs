using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static event Action<int> OnScoreChanged;
    public static event Action<int> OnBestScoreChanged;
    public int score;
    private int bestScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        OnBestScoreChanged?.Invoke(bestScore); // Kích ho?t s? ki?n cho UI hi?n th? ?i?m cao nh?t
    }
    public void AddScore(/*int points*/)
    {
        score += 1;
        OnScoreChanged?.Invoke(score);
         // Kích ho?t s? ki?n khi ?i?m thay ??i
        
        if (score > bestScore)
        {
            bestScore = score;
        }
    }

    public void OnReloadClicked()
    {
        ScoreManager.OnScoreChanged?.Invoke(score);
        ScoreManager.OnBestScoreChanged?.Invoke(bestScore);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
