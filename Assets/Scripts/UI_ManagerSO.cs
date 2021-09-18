#region Required Assemblies
using UnityEngine;
#endregion

/// <summary>
/// This is main UI handler class which will listen all events created by 
/// <c>UI_Switcher.cs</c> class, and do specific functionality according to 
/// desired channels
/// </summary>
[CreateAssetMenu(menuName = "UI Module/UI Manager")]
public class UI_ManagerSO : ScriptableObject
{
    // Channel Event for switching two panels (Opening one panel and Closing other)
    [SerializeField] private UI_SwitcherChannelSO panelChangeChannelObj;
    // Channel Event for Opening perticular panel object
    [SerializeField] private UI_SwitcherChannelSO panelOpenChannelObj;
    // Channel Event for Closing perticular panel object
    [SerializeField] private UI_SwitcherChannelSO panelCloseChannelObj;

    /// <summary>
    /// This function will subscribe all events
    /// </summary>
    private void OnEnable()
    {
        panelChangeChannelObj.TurnOnAndOffPanels += ChangePanel;
        panelOpenChannelObj.TurnOnOrOffPanel += PanelOpen;
        panelCloseChannelObj.TurnOnOrOffPanel += PanelClose;
    }

    /// <summary>
    /// Function for opening perticular panel
    /// </summary>
    /// <param name="panelToOpen"> This is panel to be opened </param>
    void PanelOpen(GameObject panelToOpen) {
        panelToOpen.SetActive(true);
    }

    /// <summary>
    /// Function for Closing perticular panel
    /// </summary>
    /// <param name="panelToClose"> This is panel to be close </param>
    void PanelClose(GameObject panelToClose)
    {
        panelToClose.SetActive(false);
    }

    /// <summary>
    /// Funtion for switching panels
    /// </summary>
    /// <param name="panelToOpen"> Panel which is being Open </param>
    /// <param name="panelToClose"> Panel which is being Close </param>
    void ChangePanel(GameObject panelToOpen, GameObject panelToClose) {
        panelToOpen.SetActive(true);
        panelToClose.SetActive(false);
    }

    /// <summary>
    /// This function will desubscribe all events
    /// </summary>
    private void OnDisable()
    {
        panelChangeChannelObj.TurnOnAndOffPanels -= ChangePanel;
        panelOpenChannelObj.TurnOnOrOffPanel -= PanelOpen;
        panelCloseChannelObj.TurnOnOrOffPanel -= PanelClose;
    }
}
