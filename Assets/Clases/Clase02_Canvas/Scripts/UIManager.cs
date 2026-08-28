using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnSettings;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnBack;

    private void Awake()
    {
        btnPlay.onClick.AddListener(OnPlayClicked); // "When click in btnPlay ejecuta OnPlayClicked
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnPlayClicked () // this is the function called OnPlayClicked which is going to run when the btnPlay click
    {
        Debug.Log("play has been clicked");
    }

}
