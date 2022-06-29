using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=rayZTQsOhKg

public class Player1Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10.0f; 
    Vector2 horizontalInputPlayer1;

    void Update()
    {
        Vector3 horizontalVelocity = (Vector3.right * horizontalInputPlayer1.x + Vector3.forward * horizontalInputPlayer1.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 input)
    {
        horizontalInputPlayer1 = input;

    }

}
