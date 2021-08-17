using System.Collections;
using System.Collections.Generic;
using CUP;

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Chronos))]
public class ChronoWorldComponentInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button(Chronos.Main.WorldIsMove ? "Stop" : "Play"))
            Chronos.Main.SetTimeline(!Chronos.Main.WorldIsMove);
    }
}