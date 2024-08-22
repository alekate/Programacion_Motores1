using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Header("RotationKeys")]
    [SerializeField] KeyCode keyRotateRight = KeyCode.E;
    [SerializeField] KeyCode keyRotateLeft = KeyCode.Q;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyRotateRight))
        {
            transform.Rotate(new Vector3(0, 0, -10));
        }

        if (Input.GetKeyDown(keyRotateLeft))
        {
            transform.Rotate(new Vector3(0, 0, 10));
        }
    }
}
