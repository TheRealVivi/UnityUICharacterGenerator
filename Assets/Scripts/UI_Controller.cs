using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//needed to load new scenes

public class UI_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Loads next scene
    public void LoadNextScene()
    {
        SceneManager.LoadScene("CharacterGenerator");
    }

    public void MyButtonPressed()
    {
        Debug.Log("Pressed!");
    }
}
