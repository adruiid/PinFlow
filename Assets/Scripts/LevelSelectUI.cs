using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectUI : MonoBehaviour
{
    public void OnBackPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
