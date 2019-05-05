using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLaunchpad : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Invoke("sceneLoader", 3f);
        }
    }

    void sceneLoader()
    {
        SceneManager.LoadScene("Winner");
    }
}
