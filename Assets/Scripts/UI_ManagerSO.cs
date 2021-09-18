using UnityEngine;

[CreateAssetMenu(menuName = "UI Module/UI Manager")]
public class UI_ManagerSO : ScriptableObject
{
    [SerializeField] private PanelChangeChannelSO panelChangeChannelObj;
    [SerializeField] private PanelChangeChannelSO panelOpenChannelObj;
    [SerializeField] private PanelChangeChannelSO panelCloseChannelObj;

    private void OnEnable()
    {
        panelChangeChannelObj.TurnOnAndOffPanels += ChangePanel;
        panelOpenChannelObj.TurnOnOrOffPanel += PanelOpen;
        panelCloseChannelObj.TurnOnOrOffPanel += PanelClose;
    }

    void PanelOpen(GameObject panelToOpen) {
        panelToOpen.SetActive(true);
    }

    void PanelClose(GameObject panelToClose)
    {
        panelToClose.SetActive(false);
    }

    void ChangePanel(GameObject panelToOpen, GameObject panelToClose) {
        panelToOpen.SetActive(true);
        panelToClose.SetActive(false);
    }

    private void OnDisable()
    {
        panelChangeChannelObj.TurnOnAndOffPanels -= ChangePanel;
        panelOpenChannelObj.TurnOnOrOffPanel -= PanelOpen;
        panelCloseChannelObj.TurnOnOrOffPanel -= PanelClose;
    }
}
