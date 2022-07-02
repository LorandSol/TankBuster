using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int playerScore1;
    public int playerScore2;

    private float timer = 10.0f;
    private bool gameOver = false;

    private void Start()
    {
        playerScore1 = 0;
        playerScore2 = 0;

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
        }
    }
    
    public void GameOver()
    {
        if (gameOver == true)
        {
            if (playerScore1 > playerScore2)
            {
                Debug.Log("Player 1 wins!");
            }
            else if (playerScore2 > playerScore1)
            {
                Debug.Log("Player 2 wins!");
            }
            else if (playerScore1 == playerScore2)
            {
                Debug.Log("It's a tie!");
            }
        }
    }
}
