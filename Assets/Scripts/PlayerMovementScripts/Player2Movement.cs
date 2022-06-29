using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=rayZTQsOhKg

public class Player2Movement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 10.0f;
    Vector2 horizontalInputPlayer2;

    void Update()
    {
        Vector3 horizontalVelocity = (Vector3.right * horizontalInputPlayer2.x + Vector3.forward * horizontalInputPlayer2.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 input)
    {
        horizontalInputPlayer2 = input;
    }

}
