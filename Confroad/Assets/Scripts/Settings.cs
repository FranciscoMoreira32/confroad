using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public GameObject optionsPanel, Player, menu;

    public Slider Slider_speed;

    public void ShowOptions(bool enable)
    {
        optionsPanel.SetActive(enable);

        if (enable)
        {
            ShowMainMenu(false);
        }
        else
        {
            ShowMainMenu(true);
        }


    }
    public void ShowMainMenu(bool enable)
    {
        menu.SetActive(enable);
    }

    public void ApplyChanges()
    {
        Player.GetComponent<PlayerControl>().speed = SettingsSingleton.Instance.speed;

        ShowOptions(true);
        ShowMainMenu(false);
    }

    void Start()
    {

      SetSliderDefaults();
    }

   void SetSliderDefaults()
    {
        Slider_speed.value = SettingsSingleton.Instance.speed;
    }


    public void SetSpeedPwr()
    {
        SettingsSingleton.Instance.speed = Slider_speed.value;
    }
 


}