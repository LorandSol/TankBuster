using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class playButton : MonoBehaviour
{
    public GameObject startPanel; 

    // Start is called before the first frame update
    void Start()
    {
        startPanel.gameObject.SetActive(true);
    }

    private void Update()
    {
        Time.timeScale = 0f; 
        
    }

    public void Play()
    {
        Time.timeScale = 1f;
        startPanel.gameObject.SetActive(false); 
    }
}
