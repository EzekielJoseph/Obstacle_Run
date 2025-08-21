using TMPro;
using UnityEngine;

public class ScoreManagement : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;   
    public float elapsedTime = 0f;
    private bool isAlive = true;

    public int startTime = 30; 
    private float remainingTime;

    private void Start()
    {
        remainingTime = startTime;
    }

    private void Update()
    {
        if (isAlive)
        {
            // Hitung score berdasarkan waktu hidup
            elapsedTime += Time.deltaTime;
            if (scoreText != null)
                scoreText.text = "Score: " + Mathf.FloorToInt(elapsedTime);

            // Countdown timer
            remainingTime -= Time.deltaTime;
            if (timerText != null)
                timerText.text = "Time: " + Mathf.CeilToInt(remainingTime);

            // Kalau timer habis
            if (remainingTime <= 0)
            {
                isAlive = false;
                FindObjectOfType<Rewards>().ShowReward();
            }
        }
    }

    public void StopScore()
    {
        isAlive = false;
    }

    public int GetScore()
    {
        return Mathf.FloorToInt(elapsedTime);
    }
}
