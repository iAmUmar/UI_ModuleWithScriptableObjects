#region Required Assemblies
using UnityEngine;
#endregion

/// <summary>
/// This class will initiate perticluar events 
/// which will be handled by <c>UI_ManagerSO.cs</c> 
/// class.
/// </summary>
public class UI_Switcher : MonoBehaviour
{
    public GameObject panelToOpen, panelToClose;
    public UI_SwitcherChannelSO panelChangeChannelObj;
    
    /// <summary>
    /// Function use to closeone panel and open other
    /// </summary>
    public void SwitchPanel()
    {
        panelChangeChannelObj.TurnOnAndOffPanels(panelToOpen, panelToClose);
    }

    /// <summary>
    /// Function use to Open specific panel
    /// </summary>
    public void OpenPanel() {
        panelChangeChannelObj.TurnOnOrOffPanel(panelToOpen);
    }

    /// <summary>
    /// Function use to Close specific panel
    /// </summary>
    public void ClosePanel()
    {
        panelChangeChannelObj.TurnOnOrOffPanel(panelToClose);
    }
}
