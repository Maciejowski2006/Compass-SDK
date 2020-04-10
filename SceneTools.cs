using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneTools : EditorWindow
{
    [MenuItem("Compass Tools/Scene Tools")]
    static void Init()
    {
        SceneTools window = (SceneTools)EditorWindow.GetWindow(typeof(SceneTools));
        window.Show();
    }

    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Main Menu") && EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {            
            EditorSceneManager.OpenScene("Assets/Scenes/Main.unity", OpenSceneMode.Single);
        }
        if (GUILayout.Button("Game") && EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/Game.unity", OpenSceneMode.Single);

        }
        EditorGUILayout.EndHorizontal();
    }

}
