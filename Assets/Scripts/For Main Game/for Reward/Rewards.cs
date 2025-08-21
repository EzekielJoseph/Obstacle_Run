using TMPro;
using UnityEngine;

public class Rewards : MonoBehaviour
{
    public GameObject rewardPanel;
    public GameObject player;
    public TextMeshProUGUI finalRewardText;
    public TextMeshProUGUI finalScoreText;

    public int bronzeLimit = 8;
    public int silverLimit = 15;
    public int goldLimit = 25;

    public string bronzeReward = "Bronze";
    public string silverReward = "Silver";
    public string goldReward = "Gold";

    private void Start()
    {
        if (rewardPanel != null)
            rewardPanel.SetActive(false);
    }

    public void ShowReward()
    {
        string reward = GetReward();
        player.SetActive(false); 

        if (rewardPanel != null)
        {
            rewardPanel.SetActive(true);

            if (finalRewardText != null)
            {
                finalRewardText.text = "Your Reward: " + reward;
            }

            if (finalScoreText != null)
            {
                finalScoreText.text = "Final Score: " + FindObjectOfType<ScoreManagement>().GetScore().ToString();
            }
        }
    }

    private string GetReward()
    {
        ScoreManagement scoreManager = FindObjectOfType<ScoreManagement>();
        int score = (scoreManager != null) ? scoreManager.GetScore() : 0;

        if (score >= goldLimit) return goldReward;
        else if (score >= silverLimit) return silverReward;
        else if (score >= bronzeLimit) return bronzeReward;
        else return "No Reward";
    }
}
