using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private GameObject player;
    public float velocity = 5f;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        transform.Translate(new Vector2(0,-velocity * Time.deltaTime));

        if (transform.position.y < player.transform.position.y)
        {
            Debug.Log("destroyed");
            //Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You hit something");
        if (collision.collider.tag == "Player")
        {
            Debug.Log("You hit the player");
            //Destroy(this.gameObject);
        }
    }
}
