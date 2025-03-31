using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
