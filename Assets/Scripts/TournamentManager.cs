using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TournamentManager : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("Bart Zmiaczek"))
        {
            PlayerPrefs.SetInt("Bart Zmiaczek", 0);
            PlayerPrefs.SetInt("Loen Maesen", 0);
            PlayerPrefs.SetInt("Makij Janik", 0);
            PlayerPrefs.SetInt("Fried Miedgren", 0);
            PlayerPrefs.SetInt("Rob Blam", 0);
            PlayerPrefs.SetInt("David Bangly", 0);
            PlayerPrefs.SetInt("Prat Kudka", 0);
            PlayerPrefs.SetInt("Teu Wuff", 0);
            PlayerPrefs.SetInt("Miarten Vakli", 0);
            PlayerPrefs.SetInt("Jimi Dyola", 0);
            PlayerPrefs.SetInt("Mikki Mikkel", 0);
            PlayerPrefs.SetInt("Jackson Holeson", 0);
            PlayerPrefs.SetInt("Maxi Firke", 0);
            PlayerPrefs.SetInt("Andron Thom", 0);
            PlayerPrefs.SetInt("Kjal Niasson", 0);
            PlayerPrefs.SetInt("Andij Liewed", 0);
            PlayerPrefs.SetInt("GPActive", 0);
            PlayerPrefs.SetInt("CurrentRound", 1);
            PlayerPrefs.SetString("GPRider", "");
            Load();
        }
        else
        {
            Load();
        }
        if(!PlayerPrefs.HasKey("Bart Zmiaczek Tournament"))
        {
            PlayerPrefs.SetInt("Bart Zmiaczek Tournament", 0);
            PlayerPrefs.SetInt("Loen Maesen Tournament", 0);
            PlayerPrefs.SetInt("Makij Janik Tournament", 0);
            PlayerPrefs.SetInt("Fried Miedgren Tournament", 0);
            PlayerPrefs.SetInt("Rob Blam Tournament", 0);
            PlayerPrefs.SetInt("David Bangly Tournament", 0);
            PlayerPrefs.SetInt("Prat Kudka Tournament", 0);
            PlayerPrefs.SetInt("Teu Wuff Tournament", 0);
            PlayerPrefs.SetInt("Miarten Vakli Tournament", 0);
            PlayerPrefs.SetInt("Jimi Dyola Tournament", 0);
            PlayerPrefs.SetInt("Mikki Mikkel Tournament", 0);
            PlayerPrefs.SetInt("Jackson Holeson Tournament", 0);
            PlayerPrefs.SetInt("Maxi Firke Tournament", 0);
            PlayerPrefs.SetInt("Andron Thom Tournament", 0);
            PlayerPrefs.SetInt("Kjal Niasson Tournament", 0);
            PlayerPrefs.SetInt("Andij Liewed Tournament", 0);
            Load();
        }
        else
        {
            Load();
        }
    }
    private void Load()
    {
        DataTransmissionScript.BartZmiaczekPoints = PlayerPrefs.GetInt("Bart Zmiaczek");
        DataTransmissionScript.LoenMaesenPoints = PlayerPrefs.GetInt("Loen Maesen");
        DataTransmissionScript.MakijJanikPoints = PlayerPrefs.GetInt("Makij Janik");
        DataTransmissionScript.FriedMiedgrenPoints = PlayerPrefs.GetInt("Fried Miedgren");
        DataTransmissionScript.RobBlamPoints = PlayerPrefs.GetInt("Rob Blam");
        DataTransmissionScript.DavidBanglyPoints = PlayerPrefs.GetInt("David Bangly");
        DataTransmissionScript.PratKudkaPoints = PlayerPrefs.GetInt("Prat Kudka");
        DataTransmissionScript.TeuWuffPoints = PlayerPrefs.GetInt("Teu Wuff");
        DataTransmissionScript.MiartenVakliPoints = PlayerPrefs.GetInt("Miarten Vakli");
        DataTransmissionScript.JimiDyolaPoints = PlayerPrefs.GetInt("Jimi Dyola");
        DataTransmissionScript.MikkiMikkelPoints = PlayerPrefs.GetInt("Mikki Mikkel");
        DataTransmissionScript.JacksonHolesonPoints = PlayerPrefs.GetInt("Jackson Holeson");
        DataTransmissionScript.MaxiFirkePoints = PlayerPrefs.GetInt("Maxi Firke");
        DataTransmissionScript.AndronThomPoints = PlayerPrefs.GetInt("Andron Thom");
        DataTransmissionScript.KjalNiassonPoints = PlayerPrefs.GetInt("Kjal Niasson");
        DataTransmissionScript.AndijLiewedPoints = PlayerPrefs.GetInt("Andij Liewed");
        DataTransmissionScript.GPActive = PlayerPrefs.GetInt("GPActive");
        DataTransmissionScript.BartZmiaczekPointsTournament = PlayerPrefs.GetInt("Bart Zmiaczek Tournament");
        DataTransmissionScript.LoenMaesenPointsTournament = PlayerPrefs.GetInt("Loen Maesen Tournament");
        DataTransmissionScript.MakijJanikPointsTournament = PlayerPrefs.GetInt("Makij Janik Tournament");
        DataTransmissionScript.FriedMiedgrenPointsTournament = PlayerPrefs.GetInt("Fried Miedgren Tournament");
        DataTransmissionScript.RobBlamPointsTournament = PlayerPrefs.GetInt("Rob Blam Tournament");
        DataTransmissionScript.DavidBanglyPointsTournament = PlayerPrefs.GetInt("David Bangly Tournament");
        DataTransmissionScript.PratKudkaPointsTournament = PlayerPrefs.GetInt("Prat Kudka Tournament");
        DataTransmissionScript.TeuWuffPointsTournament = PlayerPrefs.GetInt("Teu Wuff Tournament");
        DataTransmissionScript.MiartenVakliPointsTournament = PlayerPrefs.GetInt("Miarten Vakli Tournament");
        DataTransmissionScript.JimiDyolaPointsTournament = PlayerPrefs.GetInt("Jimi Dyola Tournament");
        DataTransmissionScript.MikkiMikkelPointsTournament = PlayerPrefs.GetInt("Mikki Mikkel Tournament");
        DataTransmissionScript.JacksonHolesonPointsTournament = PlayerPrefs.GetInt("Jackson Holeson Tournament");
        DataTransmissionScript.MaxiFirkePointsTournament = PlayerPrefs.GetInt("Maxi Firke Tournament");
        DataTransmissionScript.AndronThomPointsTournament = PlayerPrefs.GetInt("Andron Thom Tournament");
        DataTransmissionScript.KjalNiassonPointsTournament = PlayerPrefs.GetInt("Kjal Niasson Tournament");
        DataTransmissionScript.AndijLiewedPointsTournament = PlayerPrefs.GetInt("Andij Liewed Tournament");
    }
}
