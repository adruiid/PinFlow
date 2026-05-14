using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public int currentLevelIndex;
    public int moveCount;
    public int gemBalance;
    public bool inputEnabled = true;

    void Awake() {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadLevel(int index) {
        currentLevelIndex = index;
        moveCount = 0;
        inputEnabled = true;
        SceneManager.LoadScene("Gameplay");
    }

    public void OnPinPulled() {
        moveCount++;
        UIManager.Instance.UpdateMoveCount(moveCount);
    }
}