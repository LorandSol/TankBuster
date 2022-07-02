using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawningPlay2 : MonoBehaviour
{

    public int player1Points;
    public GameObject respawnPoint;
    public GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1Bullet"))
        {

            player1Points++;         
            player.transform.position = respawnPoint.transform.position;

        }
    }
}
