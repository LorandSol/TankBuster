using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=rayZTQsOhKg

public class InputManagerPlay1 : MonoBehaviour
{
    [SerializeField] Player1Movement movement;

    Player1Controls controls;

    Player1Controls.Player1MovementActions player1Movement;

    Vector2 horizontalInputPlayer1;

    void Awake()
    {
        controls = new Player1Controls();

        // setting the controls 
        player1Movement = controls.Player1Movement;

        // getting the input
        player1Movement.HorizontalMovement.performed += ctx => horizontalInputPlayer1 = ctx.ReadValue<Vector2>();

    }

    void Update()
    {
        movement.ReceiveInput(horizontalInputPlayer1); 
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
