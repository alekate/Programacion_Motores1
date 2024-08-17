using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button quitButton;

    [Header("Players")]
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("Sliders")]
    [SerializeField] private Slider speedSlider1;
    [SerializeField] private Slider speedSlider2;

    public GameObject panelPause;
    public GameObject panelSettings;
    public GameObject panelCredits;

    void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicker);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);

        speedSlider1.onValueChanged.AddListener(OnSpeedSlider1Changed);
        speedSlider2.onValueChanged.AddListener(OnSpeedSlider2Changed);
    }

    public void OnPlayButtonClicker()
    {
        panelPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !panelPause.activeSelf)
        {
            panelPause.SetActive(true);
            panelSettings.SetActive(false);
            panelCredits.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }

    private void OnPlayButtonClicked()
    {
        panelPause.SetActive(false);
    }

    private void OnSettingsButtonClicked()
    {
        panelPause.SetActive(false);
        panelSettings.SetActive(true);

    }

    private void OnCreditsButtonClicked()
    {
        panelPause.SetActive(false);
        panelCredits.SetActive(true);
    }

    private void OnQuitButtonClicked()
    {
        panelPause.SetActive(false);
    }

    private void OnSpeedSlider1Changed(float speed)
    {
        player1.SetSpeed(speed);
    }

    private void OnSpeedSlider2Changed(float speed)
    {
        player2.SetSpeed(speed);
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
