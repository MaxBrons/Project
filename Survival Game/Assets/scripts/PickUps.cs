using System.Collections;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public Enemy[] enemy;
    public void Wait(float seconds, System.Action action)
    {
        StartCoroutine(_wait(seconds, action));
    }
    IEnumerator _wait(float time, System.Action callback)
    {
        yield return new WaitForSeconds(time);
        callback();
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "Pickup")
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i].enabled = false;
            }
            Wait(5,enableEnemy);
            c.gameObject.SetActive(false);
        }
    }

    void enableEnemy()
    {
        for (int i = 0; i < enemy.Length; i++)
        {
            enemy[i].enabled = true;
        }
    }
}
