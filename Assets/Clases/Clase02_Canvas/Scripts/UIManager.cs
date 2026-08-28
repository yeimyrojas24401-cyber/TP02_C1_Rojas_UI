using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text profileName;
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnBack;

    private void Awake()
    {
        btnPlay.onClick.AddListener();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        profileName.text = "Player_01";
    }

    void OnPlayClicked(); // Create a function

}
