using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Respawn : MonoBehaviour
{
    public GameObject player1;
    public GameObject respawnPoint1;
    public Gamemanager gameScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2Bullet"))
        {
            player1.transform.position = respawnPoint1.transform.position;
            gameScript.playerScore2++;
            gameScript.playerScoreText2.text = "Player 2: " + gameScript.playerScore2.ToString();
        }
    }
}
