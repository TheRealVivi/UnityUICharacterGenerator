using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//needed to load new scenes

public class UI_Controller : MonoBehaviour
{
    //public List<string> races = new List<string>() { "Human", "Elf" };
    //public List<string> classes = new List<string>() { "Fighter", "Bard" };
    public class Classes 
    {
        public static List<string> classes = new List<string>() { "Class", "Fighter", "Bard" };
    }
    public class Races 
    {
        public static List<string> races = new List<string>() { "Race", "Human", "Elf" };
    }


    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    // Loads next scene
    public void LoadCharacterGenScene()
    {
        SceneManager.LoadScene("CharacterGenerator");
    }

    public void LoadPlayScene() 
    {
        SceneManager.LoadScene("Play");
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

    public void CreatePressed() 
    {
        
    }



}
