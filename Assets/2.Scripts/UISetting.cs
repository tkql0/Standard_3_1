using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISetting : MonoBehaviour
{
    public GameObject settingWindow;

    private PlayerController controller;

    void Start()
    {
        controller = CharacterManager.Instance.Player.controller;
        controller.setting += Toggle;
        settingWindow.SetActive(false);
    }

    public void Toggle()
    {
        if (settingWindow.activeInHierarchy)
        {
            settingWindow.SetActive(false);
        }
        else
        {
            settingWindow.SetActive(true);
        }
    }
}
