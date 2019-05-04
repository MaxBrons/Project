using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour
{

    public Color[] Colors;
    public float Speed = 5;
    int i = 0;
    Camera Camera;
    bool change = false;

    void Start()
    {
        Camera = GetComponent<Camera>();
        i = 0;
        SetColor(Colors[i]);
    }

    public void SetColor(Color color)
    {
        Camera.backgroundColor = color;
    }

    public void CycleColors()
    {
        change = true;
    }

    void Update()
    {
        if (change)
        {
            var startColor = Camera.backgroundColor;

            var endColor = Colors[0];
            if (i + 1 < Colors.Length)
            {
                endColor = Colors[i + 1];
            }


            var newColor = Color.Lerp(startColor, endColor, Time.deltaTime * Speed);
            SetColor(newColor);

            if (newColor == endColor)
            {
                change = false;
                if (i + 1 < Colors.Length)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
        }
    }

    private void FixedUpdate()
    {
        CycleColors();
    }
}