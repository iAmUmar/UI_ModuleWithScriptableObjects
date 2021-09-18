#region Required Assemblies
using UnityEngine;
using UnityEngine.Events;
#endregion

/// <summary>
/// A Channel class consist of scriptable object, which will work as a 
/// bridge between <c>UI_Switcher.cs</c> and <c>UI_ManagerSO.cs</c> class.
/// </summary>
[CreateAssetMenu(menuName = "UI Module/Panel Switching Channel")]
public class UI_SwitcherChannelSO : ScriptableObject
{
    // Event capturing two game objects for handling two panels
    public UnityAction<GameObject, GameObject> TurnOnAndOffPanels;
    // Event for handling single panel
    public UnityAction<GameObject> TurnOnOrOffPanel;

    public void RaiseEvent(GameObject panelToOpen, GameObject panelToClose)
    {
        TurnOnAndOffPanels.Invoke(panelToOpen, panelToClose);
    }

    public void RaiseEvent(GameObject openOrClosePanel)
    {
        TurnOnOrOffPanel.Invoke(openOrClosePanel);
    }
}
