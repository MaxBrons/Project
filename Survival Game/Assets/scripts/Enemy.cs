using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float speed = 30f;
    public Collider col;
    public Vector3 startPos = new Vector3(0, 2, 0);

    public PlayerMovement pm;
    public Health hp;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            transform.position = startPos;
            hp.amountOfHearts--;
            if (hp.amountOfHearts <= 0)
            {
                pm.enabled = false;
                SceneManager.LoadScene("Dead");
            }
        }
    }
}
