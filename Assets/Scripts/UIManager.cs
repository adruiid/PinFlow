using TMPro;
using UnityEngine;

// UIManager.cs
public class UIManager : MonoBehaviour {
    public static UIManager Instance;
    [Header("Panels")]
    public CanvasGroup pausePanel;
    public CanvasGroup levelCompletePanel;
    public CanvasGroup noSlotsPanel;
    public TMP_Text moveCountLabel;

    void Awake() { Instance = this; }

    public void ShowPanel(CanvasGroup panel, bool show) {
        panel.alpha = show ? 1 : 0;
        panel.blocksRaycasts = show;
        panel.interactable = show;
    }
    public void UpdateMoveCount(int n) => moveCountLabel.text = n.ToString();
}
