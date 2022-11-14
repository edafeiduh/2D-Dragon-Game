using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeveltoLoad : MonoBehaviour
{
    public int sceneIndex;


    // This manages the level to load once a Scene Index valuse is called
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().SaveGame();
            SceneManager.LoadScene(sceneIndex); 
        }
    }
   
}
