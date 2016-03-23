using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(MetaSnap))]
public class MetaSnapEditor : Editor 
{
    public Object obj = null;
    public List<GameObject> objList;
    bool socketsOpen;

    public override void OnInspectorGUI()
    {
        GUI.skin = (GUISkin)(AssetDatabase.LoadAssetAtPath("Assets/EditorSkin.guiSkin", typeof(GUISkin)));

        MetaSnap ms = (MetaSnap)target;

        objList = ms.socketArray;

        GUILayout.BeginVertical("box");

        GUILayout.Label("MetaSnap");

        obj = EditorGUILayout.ObjectField("Socket Prefab", obj, typeof(Object), true, GUILayout.MinWidth(235f), GUILayout.MaxWidth(1000f));

        if (obj)
        {
            ms.socketPrefab = obj;
        }

        EditorGUILayout.BeginVertical("box");
        if (GUILayout.Button("Add manually", GUILayout.MinWidth(100f), GUILayout.MaxWidth(1000f)))
        {
            ms.AddSocketManually();
        }

        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("Open Presets", GUILayout.MinWidth(25f), GUILayout.MaxWidth(1000f)))
        {
            ms.addedSocket = true;
        }

        if (GUILayout.Button("Close Presets", GUILayout.MinWidth(25f), GUILayout.MaxWidth(1000f)))
        {
            ms.addedSocket = false;
        }

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.BeginVertical();

        if (ms.addedSocket)
        {
            EditorGUILayout.BeginVertical();
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Add to surface", GUILayout.MinWidth(25f), GUILayout.MaxWidth(500f)))
            {
                ms.AddSocketSurface();
            }

            if (GUILayout.Button("Add to edge", GUILayout.MinWidth(25f), GUILayout.MaxWidth(500f)))
            {
                ms.AddSocketEdge();
            }

            EditorGUILayout.EndHorizontal();
            EditorGUILayout.EndVertical();
        }

        EditorGUILayout.EndVertical();
        EditorGUILayout.EndVertical();

        if (ms.socketArray.Count != 0)
        {
            if(socketsOpen)
            {
                EditorGUILayout.BeginVertical("box");

                for (int i = 0; i < ms.socketArray.Count; i++)
                {
                    EditorGUILayout.BeginHorizontal("box");

                    ms.socketArray[i] = (GameObject)EditorGUILayout.ObjectField("Socket " + i, ms.socketArray[i], typeof(Object), false, GUILayout.MinWidth(100f), GUILayout.MaxWidth(1000f));

                    if (GUILayout.Button("-", GUILayout.MinWidth(15f), GUILayout.MaxWidth(50f)))
                    {
                        ms.RemoveSocket(i);
                    }

                    EditorGUILayout.EndHorizontal();
                }

                EditorGUILayout.EndVertical();
            }

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Open Sockets", GUILayout.MinWidth(25f), GUILayout.MaxWidth(500f)))
            {
                socketsOpen = true;
            }

            if (GUILayout.Button("Close Sockets", GUILayout.MinWidth(25f), GUILayout.MaxWidth(500f)))
            {
                socketsOpen = false;
            }

            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.EndVertical();        
    }
}