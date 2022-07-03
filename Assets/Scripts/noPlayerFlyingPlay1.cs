using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noPlayerFlyingPlay1 : MonoBehaviour
{
    //public GameObject player1Bullet;
    //public GameObject player2Bullet;

    public Collider player1BulletCollider; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1Bullet"))
        {
            
                player1BulletCollider.enabled = !player1BulletCollider.enabled;
            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player1Bullet"))
        {
            if (!player1BulletCollider.enabled) {
                player1BulletCollider.enabled = player1BulletCollider.enabled;
            }
        }
    }

}
