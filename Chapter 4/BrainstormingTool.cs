using UnityEditor;
using UnityEngine;
using System.Collections;

public class BrainstormingTool : EditorWindow {

    Vector2 scroll;
    string ideas = "My first Idea";
    string[] ideasArray;
    string extractedIdea;

    // Add menu item named "Brainstorming Tool" to the Window menu
    [MenuItem("Window/Brainstorming Tool")]
    public static void ShowWindow() {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(BrainstormingTool));
    }
    void OnGUI() {
        GUILayout.Label("Ideas", EditorStyles.boldLabel);

        scroll = EditorGUILayout.BeginScrollView(scroll);
        ideas = EditorGUILayout.TextArea(ideas, GUILayout.Height(position.height - 30));
        EditorGUILayout.EndScrollView();

        if (GUILayout.Button("Extract")) {
            ideasArray = ideas.Split('\n');
            extractedIdea = ideasArray[Random.Range(0, ideasArray.Length)];
        }

        GUILayout.Label("Extracted Idea", EditorStyles.boldLabel);
        EditorGUILayout.HelpBox(extractedIdea, MessageType.None);
    }
}
