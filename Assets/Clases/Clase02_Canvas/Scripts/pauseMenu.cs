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

    [SerializeField] private GameObject canvasPauseMenu;

    private bool isPause = false;

    void Awake ()
    {
        settingsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        pausePanel.SetActive(false);
        canvasPauseMenu.SetActive(false);
        btnContinue.onClick.AddListener(OnContinueClicked);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void OnDestroy()
    {
        btnContinue.onClick.RemoveListener(OnContinueClicked);
    }

    private void TogglePause()
    {
        isPause = !isPause;

        pausePanel.SetActive(isPause);

        if (isPause)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    private void OnContinueClicked()
    {
        isPause = false;

        pausePanel.SetActive(false);

        Time.timeScale = 1f;
    }
}

