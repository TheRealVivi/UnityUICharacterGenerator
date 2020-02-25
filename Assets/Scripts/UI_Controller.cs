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

    public void LoadPrevScene() 
    {
        SceneManager.LoadScene("StartScene");
    }

    public void MyButtonPressed()
    {
        Debug.Log("Pressed!");
    }

    public void QuitPressed() 
    {
        Debug.Log("Quit called");

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif  

    }


    //dd_Races.AddOptions(Races);
    public void ClassChanged(int index) 
    {
        //TODO: logic to recieve text


    }
}
