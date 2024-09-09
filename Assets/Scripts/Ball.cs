using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float initialVel = 4f;
    [SerializeField] private float velMultiplier = 1.1f;
    [SerializeField] private ForceMode2D forceMode = ForceMode2D.Impulse;

    private Rigidbody2D ballRb;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    public void Launch()
    {
        float xDir = Random.Range(0, 2) == 0 ? 1 : -1;
        float yDir = Random.Range(0, 2) == 0 ? 1 : -1;

        Vector2 launchDirection = new Vector2(xDir, yDir).normalized;
        ballRb.AddForce(launchDirection * initialVel, forceMode);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 reflectDir = Vector2.Reflect(ballRb.velocity.normalized, collision.contacts[0].normal);
            ballRb.AddForce(reflectDir * ballRb.velocity.magnitude * (velMultiplier - 1), forceMode);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("P1 Goal"))
        {
            GameManager.Instance.Player2Scored();
            GameManager.Instance.Restart();
            Launch();
        }
        else if (collision.gameObject.CompareTag("P2 Goal"))
        {
            GameManager.Instance.Player1Scored();
            GameManager.Instance.Restart();
            Launch();
        }
    }
}
