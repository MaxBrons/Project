using UnityEngine;

public class CameraCap : MonoBehaviour
{

    public float minPosX;
    public float maxPosX;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");   
    }

    void Update()
    {
        float X = Mathf.Clamp(player.transform.position.x,minPosX,maxPosX);
    }
}
