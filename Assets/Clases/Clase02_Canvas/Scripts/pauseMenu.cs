using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnSettings;


    [Header("Panels")]
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private GameObject pausePanel;

    void Awake ()
    {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        btnContinue.onClick.AddListener(OnContinueClicked);
    }

    void OnContinueClicked ()
    {
        pausePanel.SetActive(false);
    }
}
