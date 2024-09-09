using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button quitButton;

    [Header("Panels")]
    public GameObject panelMenu;
    public GameObject panelCredits;
    public GameObject panelGamePlay;

    void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicker);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);

        Time.timeScale = 0;

        panelGamePlay.SetActive(false);
    }

    void Update()
    {

    }

    public void OnPlayButtonClicker()
    {
        panelMenu.SetActive(false);
        Time.timeScale = 1;
        panelGamePlay.SetActive(true);
    }

    private void OnCreditsButtonClicked()
    {
        panelMenu.SetActive(false);
        panelCredits.SetActive(true);
    }

    private void OnQuitButtonClicked()
    {
        panelMenu.SetActive(false);
        Application.Quit();
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }
}
