using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    private GameObject platformClone;
    public float numberOfPlatforms = 0;
    public float levelWidth = 6f;
    public float minY = .2f;
    public float maxY = 2f;
    Vector3 spawnPosition = new Vector3();
    public ArrayList platforms;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "launchpad")
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            platformClone = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}