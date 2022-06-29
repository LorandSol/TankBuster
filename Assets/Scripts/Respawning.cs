using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawning : MonoBehaviour
{

    public bool respawn;
    public int playerLives; 
    
    // Start is called before the first frame update
    void Start()
    {
        respawn = false;
        playerLives = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
