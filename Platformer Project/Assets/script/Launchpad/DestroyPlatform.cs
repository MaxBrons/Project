using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "launchpad" || collision.collider.tag == "meteorite")
        {
            Destroy(collision.gameObject);
        }
    }
}
