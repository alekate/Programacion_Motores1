using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanging : MonoBehaviour
{

    [Header("Sprite Renderer")]
    [SerializeField] SpriteRenderer player1SpriteRenderer;
    [SerializeField] SpriteRenderer player2SpriteRenderer;

    [Header("Image")]
    [SerializeField] private Image player1SettingsImage;
    [SerializeField] private Image player2SettingsImage;

    public void Player1ChangeColor()
    {
        Color newColor = Random.ColorHSV();
        player1SpriteRenderer.color = newColor;
        player1SettingsImage.color = newColor;

    }

    public void Player2ChangeColor()
    {
        Color newColor = Random.ColorHSV();
        player2SpriteRenderer.color = newColor;
        player2SettingsImage.color = newColor;
    }
}
