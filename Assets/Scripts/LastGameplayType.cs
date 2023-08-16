using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastGameplayType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Training"))
        {
            PlayerPrefs.SetInt("Training", 0);
            PlayerPrefs.SetInt("LeagueMatch", 0);
            PlayerPrefs.SetInt("Tournament", 0);
            Load();
        }
        else
        {
            Load();
        }
    }
    private void Load()
    {
        DataTransmissionScript.lastTraining = PlayerPrefs.GetInt("Training");
        DataTransmissionScript.lastLeagueMatch = PlayerPrefs.GetInt("LeagueMatch");
        DataTransmissionScript.lastTournament = PlayerPrefs.GetInt("Tournament");
    }
}
