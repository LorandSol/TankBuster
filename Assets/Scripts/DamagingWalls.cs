using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingWalls : MonoBehaviour
{
    public int boxHealth;
    public GameObject box;
    public Material damangedMaterial;
    public Transform damangedBoxes;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player1Bullet") | collision.gameObject.CompareTag("Player2Bullet"))
        {
            boxHealth--;
            GetComponent<Renderer>().material = damangedMaterial; // change material
            if(boxHealth == 0)
            {
                Destroy(box); 
            }
        }
    }
}
