using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=rayZTQsOhKg

public class InputManagerPlay2 : MonoBehaviour
{
    [SerializeField] Player2Movement movement;

    Player2Controls controls;

    Player2Controls.Player2MovementActions player2Movement;

    Vector2 horizontalInputPlayer2;

    void Awake()
    {
        controls = new Player2Controls();

        // setting the controls 
        player2Movement = controls.Player2Movement;

        // getting the input
        player2Movement.HorizontalMovement.performed += ctx => horizontalInputPlayer2 = ctx.ReadValue<Vector2>();

    }

    void Update()
    {
        movement.ReceiveInput(horizontalInputPlayer2);
    }

    void OnEnable()
    {
        controls.Enable();

    }

    void OnDisable()
    {
        controls.Disable();
    }
}
