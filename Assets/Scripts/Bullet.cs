using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask collisionMask;

    public Transform bullet;
    private float speed = 100;

    // Update is called once per frame
    void Update()
    {
        // Bullet goes pew pew (moves forward)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .1f, collisionMask))
        {
            Vector3 reflect = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflect.z, reflect.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }




    }

}
