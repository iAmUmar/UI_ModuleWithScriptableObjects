using UnityEngine;

public class UI_Switcher : MonoBehaviour
{
    public GameObject panelToOpen, panelToClose;
    [SerializeField] private PanelChangeChannelSO panelChangeChannelObj;

    public void SwitchPanel()
    {
        panelChangeChannelObj.TurnOnAndOffPanels(panelToOpen, panelToClose);
    }

    public void OpenPanel() {
        panelChangeChannelObj.TurnOnOrOffPanel(panelToOpen);
    }

    public void ClosePanel()
    {
        panelChangeChannelObj.TurnOnOrOffPanel(panelToClose);
    }
}
