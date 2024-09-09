using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    [Header("Players")]
    [SerializeField] private Movement player1;
    [SerializeField] private Movement player2;

    [Header("Sliders")]
    [SerializeField] private Slider speedSlider1;
    [SerializeField] private Slider speedSlider2;
    [SerializeField] private Slider heightSlider1;
    [SerializeField] private Slider heightSlider2;

    [Header("Texts")]
    [SerializeField] private TextMeshProUGUI textSpeedP1;
    [SerializeField] private TextMeshProUGUI textSpeedP2;
    [SerializeField] private TextMeshProUGUI textHeightP1;
    [SerializeField] private TextMeshProUGUI textHeightP2;

    [Header("Transforms")]
    [SerializeField] private Transform player1Transform;
    [SerializeField] private Transform player2Transform;



    void Awake()
    {
        speedSlider1.onValueChanged.AddListener(OnSpeedSlider1Changed);
        speedSlider2.onValueChanged.AddListener(OnSpeedSlider2Changed);
        heightSlider1.onValueChanged.AddListener(OnHeightSlider1Changed);
        heightSlider2.onValueChanged.AddListener(OnHeightSlider2Changed);
    }

    private void OnSpeedSlider1Changed(float speed)
    {
        textSpeedP1.text = speed.ToString();
        player1.SetSpeed(speed);
    }

    private void OnSpeedSlider2Changed(float speed)
    {
        textSpeedP2.text = speed.ToString();
        player2.SetSpeed(speed);
    }

    private void OnHeightSlider1Changed(float height)
    {
        textHeightP1.text = height.ToString();
        Vector3 scale = player1Transform.localScale;
        player1Transform.localScale = new Vector3(height, scale.y , scale.z);
    }

    private void OnHeightSlider2Changed(float height)
    {
        textHeightP2.text = height.ToString();
        Vector3 scale = player2Transform.localScale;
        player2Transform.localScale = new Vector3(height, scale.y , scale.z);
    }
}
