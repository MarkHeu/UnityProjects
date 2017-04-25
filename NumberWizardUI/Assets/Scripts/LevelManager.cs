using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

 public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        // old
        // Application.LoadLevel(name);
        // new
        SceneManager.LoadScene(name); 
    }
 public void Quit()
    {
        Debug.Log("Quit Game Requested");
        Application.Quit();
    }
}
