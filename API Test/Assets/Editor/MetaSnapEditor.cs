using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
//[System.Serializable]
[CustomEditor(typeof(MetaSnap))]
//public class MetaSnapEditor : Editor {
public class MetaSnapEditor : Editor 
{
    public Object obj = null;
    public List<Object> objList;

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();

        MetaSnap ms = (MetaSnap)target;        

        

        EditorGUILayout.LabelField("MetaSnap");

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

            if (GUILayout.Button("Add to surface", GUILayout.MinWidth(107f), GUILayout.MaxWidth(500f)))
            {
                ms.AddSocketSurface();
            }

            if (GUILayout.Button("Add to edge", GUILayout.MinWidth(107f), GUILayout.MaxWidth(500f)))
            {
                ms.AddSocketEdge();
            }

            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("Remove preset", GUILayout.MinWidth(235f), GUILayout.MaxWidth(1000f)))
            {
                //ms.RemoveSocket();
            }

            EditorGUILayout.EndVertical();
        }

        EditorGUILayout.EndVertical();
        EditorGUILayout.EndVertical();

        EditorGUILayout.BeginVertical("box");
        EditorGUILayout.BeginHorizontal();

        for(int i = 0; i < objList.Capacity; i++)
        {
            if (GUILayout.Button("-", GUILayout.MinWidth(5f), GUILayout.MaxWidth(5f)))
            {
                ms.RemoveSocket(i);
            }

            objList[i] = EditorGUILayout.ObjectField("Socket " + i, objList[i], typeof(Object), true, GUILayout.MinWidth(100f), GUILayout.MaxWidth(1000f));            
        }        

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();

    }
}
