using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomBehaviourGeneratorWindow : EditorWindow
{
    private CustomBehaviourGenerator customBehaviourGenerator;

    [MenuItem("ArtLink/CustomBehaviours generator")]
    public static void ShowWindow()
    {
        GetWindow<CustomBehaviourGeneratorWindow>(false, "CustomBehaviours generator", true);
    }

    private void OnGUI(){
        if (customBehaviourGenerator == null)
        {
            customBehaviourGenerator = new CustomBehaviourGenerator();
        }

        customBehaviourGenerator.OnGUI();
    }
}
