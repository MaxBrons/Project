using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BackgroundColorChanger))]
class ColorUI : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        if (GUILayout.Button("Cycle"))
        {
            BackgroundColorChanger cycler = (BackgroundColorChanger)target;
            cycler.CycleColors();
        }
    }
}