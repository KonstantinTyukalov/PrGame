using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLoadLevel : MonoBehaviour
    
{
    public int Level;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            SceneManager.LoadScene(Level);
           

    }
}
