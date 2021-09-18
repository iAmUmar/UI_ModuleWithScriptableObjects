#region Required Assemblies
using UnityEngine;
using UnityEditor;
#endregion

/// <summary>
/// Script for making <c>UI_Switcher.cs</c> visually better so that different 
/// events can be handled from inspector.
/// </summary>
[CustomEditor(typeof(UI_Switcher))]
public class UI_SwitcherEditor : Editor
{
    // Clone variables of UI_Switcher.cs
    private GameObject panelToOpenProp, panelToCloseProp;
    // Clone variable of UI_Switcher.cs
    private UI_SwitcherChannelSO panelChangeChannelObjProp;
    // Serializeable properrty for making these objects on inspector
    private SerializedProperty m_panelToOpenProp, m_panelToCloseProp, m_panelChangeChannelProp;
    // Types of panel switch we want
    private string[] switchingTypes = new string[] { "Panel Change", "Panel Open", "Panel Close" };
    // Selected panel switch type
    private int switchType = 0;

    public override void OnInspectorGUI() {
        //base.OnInspectorGUI();

        // Class type whos Editor script is written
        UI_Switcher uISwitcherObj = (UI_Switcher)target;
        
        // Showing label in inspector
        GUIContent typeLabel = new GUIContent("UI Switcher Type");
        // A dropdown will be shown in inspector in order to select type of panel switch
        switchType = EditorGUILayout.Popup(typeLabel, switchType, switchingTypes);

        // Require a serializable object of class so that we can get the propert fields
        SerializedObject serializedObj = new SerializedObject(uISwitcherObj);

        if (switchType == 0)
        {
            // Showing label in inspector
            GUIContent panelToOpenLabel = new GUIContent("Panel To Open");
            // Finding the serializable property in UI_Switcher.cs
            m_panelToOpenProp = serializedObj.FindProperty("panelToOpen");
            // Gettting object referenced in this serializeble field
            panelToOpenProp = m_panelToOpenProp.objectReferenceValue as GameObject;
            // Drawing the layout in inspector for serializeable field
            EditorGUILayout.PropertyField(m_panelToOpenProp, panelToOpenLabel, panelToOpenProp);

            // Showing label in inspector
            GUIContent panelToCloseLabel = new GUIContent("Panel To Close");
            // Finding the serializable property in UI_Switcher.cs
            m_panelToCloseProp = serializedObj.FindProperty("panelToClose");
            // Gettting object referenced in this serializeble field
            panelToCloseProp = m_panelToCloseProp.objectReferenceValue as GameObject;
            // Drawing the layout in inspector for serializeable field
            EditorGUILayout.PropertyField(m_panelToCloseProp, panelToCloseLabel, panelToCloseProp);

        }
        else if (switchType == 1)
        {
            // Showing label in inspector
            GUIContent panelToOpenLabel = new GUIContent("Panel To Open");
            // Finding the serializable property in UI_Switcher.cs
            m_panelToOpenProp = serializedObj.FindProperty("panelToOpen");
            // Gettting object referenced in this serializeble field
            panelToOpenProp = m_panelToOpenProp.objectReferenceValue as GameObject;
            // Drawing the layout in inspector for serializeable field
            EditorGUILayout.PropertyField(m_panelToOpenProp, panelToOpenLabel, panelToOpenProp);
          
            Debug.Log("Open Panel");
        }
        else if (switchType == 2)
        {
            // Showing label in inspector
            GUIContent panelToCloseLabel = new GUIContent("Panel To Close");
            // Finding the serializable property in UI_Switcher.cs
            m_panelToCloseProp = serializedObj.FindProperty("panelToClose");
            // Gettting object referenced in this serializeble field
            panelToCloseProp = m_panelToCloseProp.objectReferenceValue as GameObject;
            // Drawing the layout in inspector for serializeable field
            EditorGUILayout.PropertyField(m_panelToCloseProp, panelToCloseLabel, panelToCloseProp);
            
            Debug.Log("Closing Panel");
        }

        // Showing label in inspector
        GUIContent panelChangeChannelLabel = new GUIContent("Panel Switch Channel");
        // Finding the serializable property in UI_Switcher.cs
        m_panelChangeChannelProp = serializedObj.FindProperty("panelChangeChannelObj");
        // Gettting object referenced in this serializeble field
        panelChangeChannelObjProp = m_panelChangeChannelProp.objectReferenceValue as UI_SwitcherChannelSO;
        // Drawing the layout in inspector for serializeable field
        EditorGUILayout.PropertyField(m_panelChangeChannelProp, panelChangeChannelLabel, panelChangeChannelObjProp);

        // Applying modified values to serializeable object
        serializedObj.ApplyModifiedProperties();
    }
}
