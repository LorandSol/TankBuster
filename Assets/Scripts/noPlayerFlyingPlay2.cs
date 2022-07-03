using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noPlayerFlyingPlay2 : MonoBehaviour
{
    //public GameObject player1Bullet;
    //public GameObject player2Bullet;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2Bullet"))
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
