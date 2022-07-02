using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject play1bullet;
    public GameObject play2bullet;

    public Transform shootPoint;
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject instBullet = Instantiate(play1bullet, shootPoint.position, shootPoint.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(shootPoint.transform.forward * speed);
            Destroy(instBullet, 3f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(play2bullet, shootPoint.position, shootPoint.rotation) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(shootPoint.transform.forward * speed);
            Destroy(instBullet, 3f);
        }
    }
}
