using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int amountOfHearts;

    public Image[] Hearts;
    public Sprite heartImage;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Hearts.Length; i++)
        {

            if (i < amountOfHearts)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
    }
}
