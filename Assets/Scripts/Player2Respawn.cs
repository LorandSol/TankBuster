using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Respawn : MonoBehaviour
{
    public GameObject respawnPoint2;
    public GameObject player2;
    public Gamemanager gameScript;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1Bullet"))
        {
            player2.transform.position = respawnPoint2.transform.position;
            gameScript.playerScore1++;
        }
    }
}
