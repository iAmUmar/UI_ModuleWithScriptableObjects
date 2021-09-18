using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(menuName = "UI Module/Panel Change Channel")]
public class PanelChangeChannelSO : ScriptableObject
{
    public UnityAction<GameObject, GameObject> TurnOnAndOffPanels;
    public UnityAction<GameObject> TurnOnOrOffPanel;

    public void RaiseEvent(GameObject panelToOpen, GameObject panelToClose) { 
        TurnOnAndOffPanels.Invoke(panelToOpen, panelToClose);
    }

    public void RaiseEvent(GameObject openOrClosePanel) {
        TurnOnOrOffPanel.Invoke(openOrClosePanel);
    }

}
