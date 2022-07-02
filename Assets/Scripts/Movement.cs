using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;

    private float inputX;
    private float inputZ;
    private Vector3 movement;
    private Vector3 velocity;
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player1 = GameObject.FindGameObjectWithTag("Player1");
        controller = player1.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        movement = controller.transform.forward * inputZ;
        controller.transform.Rotate(Vector3.up * inputX * (100f * Time.deltaTime));
        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
