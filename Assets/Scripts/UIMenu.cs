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
    [SerializeField] private Button exitButton;

    [Header("Players")]
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("Sliders")]
    [SerializeField] private Slider speedSlider1;
    [SerializeField] private Slider speedSlider2;

    public GameObject panelPause;

    void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicker);
        playButton.onClick.AddListener(OnSettingsButtonClicked);
        playButton.onClick.AddListener(OnCreditsButtonClicked);
        playButton.onClick.AddListener(OnQuitButtonClicked);

        speedSlider1.onValueChanged.AddListener(OnSpeedSlider1Changed);
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
    }

    private void OnCreditsButtonClicked()
    {
        panelPause.SetActive(false);
    }

    private void OnQuitButtonClicked()
    {
        panelPause.SetActive(false);
    }

    private void OnSpeedSlider1Changed(float speed)
    {
        player1.SetSpeed(speed);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
}
