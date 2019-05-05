using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject ground;
    public GameObject deathBox;
    private float topScore = 0.0f;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.zero;
        ground = GameObject.FindGameObjectWithTag("ground");
    }

    void Update()
    { 
        if (rb.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
        if (topScore > 10)
        {
            ground.SetActive(false);
            deathBox.SetActive(true);
        }
    }
}
