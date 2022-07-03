using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Respawn : MonoBehaviour
{
    public GameObject player2;
    public GameObject respawnPoint2;
    public Gamemanager gameScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1Bullet"))
        {
            player2.transform.position = respawnPoint2.transform.position;
            gameScript.playerScore1++;
            gameScript.playerScoreText1.text = "Player 1: " + gameScript.playerScore1.ToString();
        }
    }
}
