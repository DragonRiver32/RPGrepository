using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_PanelSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject PanelMenu;
    [SerializeField]
    private GameObject PanelLoadLevel;
    [SerializeField]
    private GameObject PanelOptions;

    public void PanelGameIsActive()
    {
        PanelMenu.SetActive(true);
        PanelLoadLevel.SetActive(false);
        PanelOptions.SetActive(false);
    }
    public void PanelLoadIsActive()
    {
        PanelMenu.SetActive(false);
        PanelLoadLevel.SetActive(true);
        PanelOptions.SetActive(false);
    }
    public void PanelOptionsIsActive()
    {
        PanelMenu.SetActive(false);
        PanelLoadLevel.SetActive(false);
        PanelOptions.SetActive(true);
    }
}
