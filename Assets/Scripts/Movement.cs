using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("MovementKeys")]
    [SerializeField] KeyCode keyUp = KeyCode.W;
    [SerializeField] KeyCode keyDown = KeyCode.S;
    [SerializeField] KeyCode keyLeft = KeyCode.A;
    [SerializeField] KeyCode keyRight = KeyCode.D;

    [Header("RotationKeys")]
    [SerializeField] KeyCode keyRotateRight = KeyCode.E;
    [SerializeField] KeyCode keyRotateLeft = KeyCode.Q;

    [Header("ColorKey")]
    [SerializeField] KeyCode keyColor = KeyCode.R;

    [Header("Stats and Misc")]
    [SerializeField] SpriteRenderer spriteRenderer;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = transform.position;
      
        if (Input.GetKey(keyUp))
        {
            pos.y += speed;
        }

        if (Input.GetKey(keyDown))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(keyLeft))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(keyRight))
        {
            pos.x += speed;
        }

        transform.position = pos;

        if (Input.GetKeyDown(keyRotateRight))
        {
            transform.Rotate(new Vector3(0, 0, -10));
        }

        if (Input.GetKeyDown(keyRotateLeft))
        {
            transform.Rotate(new Vector3(0, 0, 10));
        }

        if (Input.GetKeyUp(keyColor))
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        spriteRenderer.material.color = Random.ColorHSV();
    }

    public void SetSpeed(float newSpeed)
    {
        if (newSpeed < 1.5f)
        {
            speed = newSpeed;
        }
    }
}
