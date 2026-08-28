using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text profileName;
    [SerializeField] private Button playBut;
    [SerializeField] private Button pauseBut;
    [SerializeField] private Button settingsBut;
    [SerializeField] private Button creditsBut;
    [SerializeField] private Button exitBut;
    [SerializeField] private Button backBut;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        profileName.text = "Player_01";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
