using UnityEngine;
using UnityEngine.SceneManagement;//needed to load new scenes

public class UI_Controller : MonoBehaviour
{
    public void LoadCharStats()
    {
        Player.Instance.CharacterStats();
    }

    // Loads next scene
    public void LoadCharacterGenScene()
    {
        SceneManager.LoadScene("CharacterGeneratorScene");
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
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
}
