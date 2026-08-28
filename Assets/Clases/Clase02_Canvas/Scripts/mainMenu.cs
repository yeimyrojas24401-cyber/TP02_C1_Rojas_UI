using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;

    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject settingsCanvas;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayClicked); // "When click in btnPlay ejecuta OnPlayClicked
        btnSettings.onClick.AddListener(OnSettingsClicked);
        settingsCanvas.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnDestroy()
    {
        btnPlay.onClick.RemoveAllListeners();
    }
    private void OnPlayClicked () // this is the function called OnPlayClicked which is going to run when the btnPlay click
    {
        mainMenuCanvas.SetActive(false); //  When Play is clicked, this GameObject becomes inactive.
    }
    private void OnSettingsClicked ()
    {
        mainMenuCanvas.SetActive(false);
        settingsCanvas.SetActive(true);

    }

}
