using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject[] Panels;

    public void OpenPanels()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }

        foreach (var panel in Panels)
        {
            panel.SetActive(false);
        }
        
    }
    public void ClosePanel()
    {
        if (Panel != null)
            Panel.SetActive(false);
    }
}
