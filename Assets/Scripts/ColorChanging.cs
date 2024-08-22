using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    [Header("ColorKey")]
    [SerializeField] KeyCode keyColor = KeyCode.R;

    [Header("Stats and Misc")]
    [SerializeField] SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyUp(keyColor))
        {
            ChangeColor();
        }
    }
    void ChangeColor()
    {
        spriteRenderer.material.color = Random.ColorHSV();
    }
}
