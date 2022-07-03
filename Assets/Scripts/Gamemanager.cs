using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    public int playerScore1;
    public int playerScore2;
    public TextMeshProUGUI playerScoreText1;
    public TextMeshProUGUI playerScoreText2;
    public TextMeshProUGUI timerText;

    public GameObject gameOverPanel;
    public TextMeshProUGUI player1Win;
    public TextMeshProUGUI player2Win;
    public TextMeshProUGUI tieText;

    private float timer = 61.0f;
    private bool gameOver = false;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        player1Win.gameObject.SetActive(false);
        player2Win.gameObject.SetActive(false);
        tieText.gameObject.SetActive(false);

        Time.timeScale = 1;
        playerScore1 = 0;
        playerScoreText1.text = "Player 1: " + 0;
        playerScore2 = 0;
        playerScoreText2.text = "Player 2: " + 0;
        timerText.text = timer.ToString();

        InvokeRepeating("Timer", 0.0f, 1.0f);
    }

    public void Timer()
    {
        if(timer == 0)
        {
            gameOver = true;
            GameOver();
            CancelInvoke("Timer");
        }
        else
        {
            timer--;
            timerText.text = timer.ToString();
        }
    }
    
    public void GameOver()
    {
        if (gameOver == true)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            if (playerScore1 > playerScore2)
            {
                player1Win.gameObject.SetActive(true);
                timerText.gameObject.SetActive(false);
                Debug.Log("Player 1 wins!");
            }
            else if (playerScore2 > playerScore1)
            {
                player2Win.gameObject.SetActive(true);
                timerText.gameObject.SetActive(false);
                Debug.Log("Player 2 wins!");
            }
            else if (playerScore1 == playerScore2)
            {
                tieText.gameObject.SetActive(true);
                timerText.gameObject.SetActive(false);
                Debug.Log("It's a tie!");
            }
        }
    }
}
