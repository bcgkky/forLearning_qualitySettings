using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forKalite : MonoBehaviour
{

    public Dropdown kaliteDropDown;

    void Start()
    {
        if (PlayerPrefs.HasKey("Kalite"))
        {
            kaliteDropDown.value = PlayerPrefs.GetInt("Kalite");
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("Kalite"));
        }
        else
        {
            PlayerPrefs.SetInt("Kalite", 2);
            QualitySettings.SetQualityLevel(2);
            kaliteDropDown.value = 2;
        }
    }
    public void forKaliteAyar(int kalite)
    {
        PlayerPrefs.SetInt("Kalite" , kalite);

        QualitySettings.SetQualityLevel(kalite);
    }
}
