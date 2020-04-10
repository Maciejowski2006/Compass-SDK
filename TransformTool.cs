using UnityEditor;
using UnityEngine;

public class TransformTools : EditorWindow
{
    [MenuItem("Compass Tools/Transform Tools")]
    static void Init()
    {
        TransformTools window = (TransformTools)EditorWindow.GetWindow(typeof(TransformTools));
        window.Show();
        
    }

    void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Position"))
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            foreach (GameObject selected_object in selectedObjects)
            {
                Vector3 p_pos = Vector3.zero;
                
                if (selected_object.transform.parent != null)
                {
                    p_pos = selected_object.transform.parent.position;
                }
                
                selected_object.transform.position = Vector3.zero + p_pos;
            }
        }
        if (GUILayout.Button("Rotation"))
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            foreach (GameObject selected_object in selectedObjects)
            {
                Quaternion p_rot = Quaternion.identity;

                if (selected_object.transform.parent != null)
                {
                    p_rot = selected_object.transform.parent.rotation;
                }

                selected_object.transform.rotation = Quaternion.identity * p_rot;
            }

        }
        if (GUILayout.Button("Scale"))
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            foreach (GameObject selected_object in selectedObjects)
            {
                Vector3 p_scale = Vector3.one;

                if (selected_object.transform.parent != null)
                {
                    p_scale = selected_object.transform.parent.localScale;
                }

                selected_object.transform.localScale = Vector3.one;
            }
        }
        EditorGUILayout.EndHorizontal();
        if (GUILayout.Button("Reset all"))
        {
            GameObject[] selectedObjects = Selection.gameObjects;

            foreach (GameObject selected_object in selectedObjects)
            {
                Vector3 p_pos = Vector3.zero;
                Quaternion p_rot = Quaternion.identity;
                Vector3 p_scale = Vector3.one;

                if (selected_object.transform.parent != null)
                {
                    p_pos = selected_object.transform.parent.position;
                    p_rot = selected_object.transform.parent.rotation;
                    p_scale = selected_object.transform.parent.localScale;
                }

                selected_object.transform.position = Vector3.zero + p_pos;
                selected_object.transform.rotation = Quaternion.identity * p_rot;
                selected_object.transform.localScale = Vector3.one;
            }
        }
    }

}
