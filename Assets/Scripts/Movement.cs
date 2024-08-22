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
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(keyDown))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(keyLeft))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(keyRight))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;

    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
        if (newSpeed < 1.5f)
        {
            speed = newSpeed;
        }
    }

}
