using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Health))]
public class HealthEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("+10 Health"))
        {
            ((Health)target).ChangeHealth(10);
        }
        
        if (GUILayout.Button("-10 Health"))
        {
            ((Health)target).ChangeHealth(-10);
        }
        
        GUILayout.EndHorizontal();
    }
}
