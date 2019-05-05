using UnityEngine;
using UnityEngine.SceneManagement;

public class Meteorite : MonoBehaviour
{
    public float velocity = 5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You hit something");
        if (collision.collider.tag == "Player")
        {
            Debug.Log("You hit the player");
            Destroy(this.gameObject);
            SceneManager.LoadScene("Death");
        }
    }
}
