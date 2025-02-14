using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreUI : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;

    private void OnEnable()
    {
        // ??ng ký s? ki?n khi ?i?m cao nh?t thay ??i
        ScoreManager.OnBestScoreChanged += UpdateBestScoreUI;
    }

    private void OnDisable()
    {
        // H?y ??ng ký s? ki?n khi UI b? vô hi?u hóa
        ScoreManager.OnBestScoreChanged -= UpdateBestScoreUI;
    }

    private void UpdateBestScoreUI(int newBestScore)
    {
        bestScoreText.text = "Best: " + newBestScore.ToString();
    }
}
