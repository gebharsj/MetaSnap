using UnityEngine;
using UnityEditor;
using System.Collections;

public class CustomWindow : EditorWindow
{

    public static CustomWindow instance;

    [MenuItem("Tools/MetaSnap/Custom Window")]
    public static void ShowCustomWindow()
    {
        instance = (CustomWindow)EditorWindow.GetWindow(typeof(CustomWindow));
        instance.titleContent = new GUIContent("Custom Window");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable called");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable called");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy called");
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("The GUI of this window was modified.");
    }

    private void Update()
    {

    }

}