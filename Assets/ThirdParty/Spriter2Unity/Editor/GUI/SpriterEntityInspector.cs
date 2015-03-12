using UnityEngine;
using System.Collections;
using UnityEditor;
using Spriter2Unity.Runtime;

namespace Spriter2Unity.Editor.GUI
{
    using Editor = UnityEditor.Editor;

    [CustomEditor(typeof(SpriterEntity))]
    public class SpriterEntityInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            var myTarget = (SpriterEntity)target;

            myTarget.SpriteMaterial = (Material)EditorGUILayout.ObjectField("Sprite Material", myTarget.SpriteMaterial, typeof(Material), false);

            if(GUILayout.Button("Assign Material"))
            {
                myTarget.ApplyMaterial();
            }

            EditorUtility.SetDirty(target);
        }
    }
}
