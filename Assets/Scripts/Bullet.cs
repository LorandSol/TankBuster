using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask collisionMask;

    public Transform bullet;
    private float speed = 15;

    // Update is called once per frame
    void Update()
    {
        // Bullet goes pew pew (moves forward)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
