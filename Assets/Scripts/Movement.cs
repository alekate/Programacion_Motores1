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

    public float moveSpeed = 5f;

    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(keyUp))
        {
            movement.y = moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(keyDown))
        {
            movement.y = -moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(keyLeft))
        {
            movement.x = -moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(keyRight))
        {
            movement.x = moveSpeed * Time.deltaTime;
        }

        rb2d.MovePosition(rb2d.position + movement);
    }

    public void SetSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
    }
}
