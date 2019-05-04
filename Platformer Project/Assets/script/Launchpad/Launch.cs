using UnityEngine.Audio;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float jumpForce = 10f;
    AudioSource jump;

    private void Awake()
    {
        jump = FindObjectOfType<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                jump.Play();
            }
        }
    }

}