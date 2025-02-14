using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreUI : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;

    private void OnEnable()
    {
        // ??ng k� s? ki?n khi ?i?m cao nh?t thay ??i
        ScoreManager.OnBestScoreChanged += UpdateBestScoreUI;
    }

    private void OnDisable()
    {
        // H?y ??ng k� s? ki?n khi UI b? v� hi?u h�a
        ScoreManager.OnBestScoreChanged -= UpdateBestScoreUI;
    }

    private void UpdateBestScoreUI(int newBestScore)
    {
        bestScoreText.text = "Best: " + newBestScore.ToString();
    }
}
