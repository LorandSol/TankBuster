using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawningPlay1 : MonoBehaviour
{

    public int player2Points;
    public GameObject respawnPoint;
    public GameObject player; 

  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2Bullet"))
        {
            player2Points++;
            player.transform.position = respawnPoint.transform.position; 
        }
    }
}
