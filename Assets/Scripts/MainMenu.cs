using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void OnPlayPressed()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void OnQuitPressed()
    {
        Application.Quit();

    }

    public void OnSettingsPressed()
    {

    }
}