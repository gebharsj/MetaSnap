using UnityEngine;
using UnityEditor;
using System.Collections;

public class CustomSceneView : Editor {

    
    private void DrawModeGUI()
    {
        Handles.BeginGUI();

        GUILayout.BeginArea(new Rect(10f, 10f, 360, 40f));
        GUILayout.Label("Test");
        GUILayout.EndArea();

        Handles.EndGUI();
    }

    [MenuItem("Tools/MetaSnap/Custom Scene View")]
    private void OnSceneGUI()
    {
        DrawModeGUI();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
