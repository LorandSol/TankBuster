using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class playAgainButton : MonoBehaviour
{

    public GameObject startPanel; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        startPanel.gameObject.SetActive(false);
    }
}
