using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject endPlatform;
    public GameObject DESTROYER;
    private Vector3 spawnPosition = new Vector3();
    public CameraCap camCap;
    public GameObject meteorite;
    public GameObject player;
    private float numberOfPlatforms = 0;
    public float maximumPlatforms = 20;
    public float levelWidth = 6f;
    public float minY = .2f;
    public float maxY = 2f;
    public bool allowedToSpawn = true;
    public bool meteorSpawn = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "launchpad")
        {
            if (numberOfPlatforms >= maximumPlatforms && allowedToSpawn)
            {
                allowedToSpawn = false;
                Instantiate(endPlatform, spawnPosition, Quaternion.identity);
            }
            if (allowedToSpawn)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
                numberOfPlatforms++;
            }
        }
        else if (collision.collider.tag == "endLaunchpad")
        {
            DESTROYER.SetActive(false);
            camCap.timeToSmooth = 0.2f;
        }

        if (!allowedToSpawn && !meteorSpawn)
        {
            Instantiate(meteorite, player.transform.position + new Vector3(0, 20, 0), Quaternion.identity);
            meteorSpawn = true;
        }
    }
}