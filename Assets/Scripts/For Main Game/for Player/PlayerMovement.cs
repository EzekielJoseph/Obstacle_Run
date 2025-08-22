using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float minX = -2.29f;
    public float maxX = 2.29f;
    public float yPosition = -4.3f;
    public float speed = 2f;

    private ScoreManagement scoreManagement;
    private Rewards rewards;

    private void Start()
    {
        transform.position = new Vector2(0f, yPosition);
        scoreManagement = FindObjectOfType<ScoreManagement>();
        rewards = FindObjectOfType<Rewards>();
    }

    private void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            move = 1f;
        }

        Vector2 newPos = transform.position;
        newPos.x += move * speed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);

        transform.position = new Vector2(newPos.x, yPosition);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (scoreManagement != null)
            scoreManagement.StopScore();

        if (rewards != null)
            rewards.ShowReward();

        Time.timeScale = 0f; // berhentiin gameplay
    }
}
