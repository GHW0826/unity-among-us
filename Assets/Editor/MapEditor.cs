using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MapEditor
{
#if UNITY_EDITOR

    // ����Ű
    // % (Ctrl) # (Shift), & (Alt)
    [MenuItem("Tools/GeneratedMap %#g")]
    public static void HelloWorld()
    {
        if (EditorUtility.DisplayDialog("Hello World!", "Create?", "Create", "Cancel"))
        {
            new GameObject("Hello World");
        }
    }

#endif
}
