//using UnityEngine;
//using System.Collections;
//using UnityEditor;

////[CustomEditor(typeof(MetaSnap))]
////[CanEditMultipleObjects]
//public class CustomInspector : Editor {


//    [TextArea(2, 5)]
//    public string text;
    
//    public string[] convo;

//    public override void OnInspectorGUI()
//    {
//        DrawDefaultInspector();

//        EditorGUILayout.LabelField("The GUI of this inspector was modified.");

//        MetaSnap ms = (MetaSnap)target;

//        convo = ms.dialogue;
//        for(int i = 0; i < convo.Length; i++)
//        {
//            text = convo[i];
//            GUILayout.BeginHorizontal();
//            if (GUILayout.Button("Edit", GUILayout.Width(35f)))
//            {
//                Rect myWindow = GUILayout.Window(0, new Rect(10, 10, 200, 100), CreateTextEdit, "Edit Text", GUILayout.Width(200));
//            }
//            GUILayout.EndHorizontal();
//        }

//        GUILayout.Label("Add socket");
//        GUILayout.BeginHorizontal();
//        if (GUILayout.Button("Add to edge", GUILayout.Width(150f)))
//        {
//            ms.AddSocketEdge();
//        }

//        if (GUILayout.Button("Add to surface", GUILayout.Width(150f)))
//        {
//            ms.AddSocketSurface();
//        }

//        GUILayout.EndHorizontal();
//        //GUILayout.Label("Add script");
//        //if (GUILayout.Button(""))
//    }

//    void CreateTextEdit(int windowID)
//    {
//        GUILayout.TextArea(text, GUILayout.Width(200));
//    }
//}
