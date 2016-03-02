using UnityEngine;
using UnityEditor;
using System.Collections;

public class SampleMenuItem : Editor {

	[MenuItem("GameObject/MetaSnap/AddScript", false, 0)]

    public static void MyMenuItem(MenuCommand menuCommand)
    {
        GameObject gameObj = (GameObject)menuCommand.context;
        gameObj.AddComponent<MetaSnap>();
    }
}
