using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=rayZTQsOhKg movement
// https://www.youtube.com/watch?v=4HpC--2iowE&t=555s rotation

public class Player1Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10.0f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    Vector2 horizontalInputPlayer1;

    void Update()
    {

        Vector3 horizontalVelocity = (Vector3.right * horizontalInputPlayer1.x + Vector3.forward * horizontalInputPlayer1.y) * speed;

        // rotating 
        float targetAngle = Mathf.Atan2(horizontalVelocity.x, horizontalVelocity.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime); // make smooth turning

        transform.rotation = Quaternion.Euler(0f, angle, 0f);

        controller.Move(horizontalVelocity * Time.deltaTime);


    }

    public void ReceiveInput(Vector2 input)
    {
        horizontalInputPlayer1 = input;

    }

}
