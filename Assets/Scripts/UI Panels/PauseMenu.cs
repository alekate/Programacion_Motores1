using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button quitButton;

    [Header("Panels")]
    public GameObject panelPause;
    public GameObject panelSettings;
    public GameObject panelGamePlay;

    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !panelPause.activeSelf)
        {
            panelPause.SetActive(true);
            panelSettings.SetActive(false);

            Time.timeScale = 0;

            panelGamePlay.SetActive(false);
        }
    }

    public void OnPlayButtonClicker()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
        panelGamePlay.SetActive(true);
    }

    public void OnSettingsButtonClicked()
    {
        panelPause.SetActive(false);
        panelSettings.SetActive(true);
    }


    public void OnQuitButtonClicked()
    {
        panelPause.SetActive(false);
        Application.Quit();
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }
}
