using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float speed = 0.01f;
    public float speedRotation = 0.01f;
    public KeyCode keyUp = KeyCode.W;
    public KeyCode keyDown = KeyCode.S;
    public KeyCode keyLeft = KeyCode.A;
    public KeyCode keyRight = KeyCode.D;

    public KeyCode keyRotateRight = KeyCode.E;
    public KeyCode keyRotateLeft = KeyCode.Q;

    public KeyCode keyColor = KeyCode.R;

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
}
