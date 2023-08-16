using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeagueManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Goats"))
        {
            PlayerPrefs.SetInt("Goats", 0);
            PlayerPrefs.SetInt("Hammers", 0);
            PlayerPrefs.SetInt("Lions", 0);
            PlayerPrefs.SetInt("Angels", 0);
            PlayerPrefs.SetInt("Warriors", 0);
            PlayerPrefs.SetInt("Bulls", 0);
            PlayerPrefs.SetInt("Gulls", 0);
            PlayerPrefs.SetInt("Wolves", 0);
            PlayerPrefs.SetInt("LeagueActive", 0);
            PlayerPrefs.SetInt("LeagueLineCounter", 0);
            PlayerPrefs.SetString("LeagueTeam", "");
            Load();
        }
        else
        {
            Load();
        }
    }
    private void Load()
    {
        DataTransmissionScript.GoatsPoints = PlayerPrefs.GetInt("Goats");
        DataTransmissionScript.HammersPoints = PlayerPrefs.GetInt("Hammers");
        DataTransmissionScript.LionsPoints = PlayerPrefs.GetInt("Lions");
        DataTransmissionScript.AngelsPoints = PlayerPrefs.GetInt("Angels");
        DataTransmissionScript.WarriorsPoints = PlayerPrefs.GetInt("Warriors");
        DataTransmissionScript.BullsPoints = PlayerPrefs.GetInt("Bulls");
        DataTransmissionScript.GullsPoints = PlayerPrefs.GetInt("Gulls");
        DataTransmissionScript.WolvesPoints = PlayerPrefs.GetInt("Wolves");
        DataTransmissionScript.leagueLineCounter = PlayerPrefs.GetInt("LeagueLineCounter");
        DataTransmissionScript.leagueActive = PlayerPrefs.GetInt("LeagueActive");
    }
}
