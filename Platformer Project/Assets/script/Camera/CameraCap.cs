using UnityEngine;

public class CameraCap : MonoBehaviour
{

    public Transform player;
    Vector3 vel = Vector3.zero;
    public float timeToSmooth = 0.5f;
    private bool yMax = false;
    private bool yMin = true;
    private bool xMax = true;
    private bool xMin = true;
    public float YMax = 0;
    public float YMin = 0;
    public float XMax = 0;
    public float XMin = 0;

    private void FixedUpdate()
    {
        Vector3 playerPos = player.position;

        if (yMin && yMax)
        {
            playerPos.y = Mathf.Clamp(playerPos.y, YMin, YMax);
        }
        else if (yMin)
        {
            playerPos.y = Mathf.Clamp(playerPos.y, YMin, player.position.y);
        }
        else if (yMax)
        {
            playerPos.y = Mathf.Clamp(playerPos.y, player.position.y, YMax);
        }


        if (xMin && xMax)
        {
            playerPos.x = Mathf.Clamp(playerPos.x, XMin, XMax);
        }
        else if (xMin)
        {
            playerPos.x = Mathf.Clamp(playerPos.x, XMin, player.position.x);
        }
        else if (xMax)
        {
            playerPos.x = Mathf.Clamp(playerPos.x, player.position.x, XMax);
        }

        playerPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, playerPos, ref vel, timeToSmooth);
    }
    
}
