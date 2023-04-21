using UnityEditor;
using UnityEngine;

namespace Audios.Editors
{
    [CustomPropertyDrawer(typeof(AudioClipPair), true)]
    public class AudioClipPairPropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return property.isExpanded
                ? EditorGUIUtility.singleLineHeight * 3 + EditorGUIUtility.standardVerticalSpacing * 2
                : EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            property.serializedObject.ApplyModifiedProperties();
            property.serializedObject.Update();
            EditorGUI.BeginProperty(position, label, property);
            var pos = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
            property.isExpanded = EditorGUI.Foldout(pos, property.isExpanded, label);
            if (property.isExpanded)
            {
                pos.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                var clipProp = property.FindPropertyRelative("clip");
                var hashProp = property.FindPropertyRelative("hash");
                EditorGUI.indentLevel++;
                EditorGUI.PropertyField(pos, clipProp);
                if (GUI.changed)
                {
                    hashProp.stringValue = clipProp.objectReferenceValue == null
                        ? string.Empty
                        : clipProp.objectReferenceValue.name;
                }

                pos.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                EditorGUI.PropertyField(pos, hashProp);
                EditorGUI.indentLevel--;
            }

            EditorGUI.EndProperty();
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}