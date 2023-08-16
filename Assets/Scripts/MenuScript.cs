using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuScript : MonoBehaviour
{
    public GameObject leaguePanel;
    public GameObject leagueSelection;
    public GameObject GPSeasonPanel;
    public GameObject GPSeasonSelection;
    public GameObject errorText;
    public GameObject matchSelection;
    public GameObject matchScreen;
    public GameObject tournamentSelection;
    public GameObject tournamentScreen;
    public GameObject mainMenu;
    public GameObject instructionsMenu;
    public GameObject Points;
    public GameObject NextHeatButton;
    public GameObject NextResultButton;
    public GameObject LeaguePoints;
    public GameObject LeagueNextHeatButton;
    public GameObject LeagueNextResultButton;
    public GameObject HomeTeamHeatScore;
    public GameObject AwayTeamHeatScore;
    public TMP_Dropdown homeTeam;
    public TMP_Dropdown awayTeam;
    public TMP_Dropdown riderSelection;
    public TMP_Dropdown trackSelection;
    public TMP_Dropdown leagueTeam;
    public TMP_Dropdown GPRider;
    public TextAsset[] leagueMatchesProgrammes;
    public TextAsset[] tournamentProgrammes;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Training") == 1)
        {
            mainMenu.SetActive(false);
            instructionsMenu.SetActive(true);
            PlayerPrefs.SetInt("Training", 0);
        }
        if (PlayerPrefs.GetInt("LeagueMatch") == 1)
        {
            mainMenu.SetActive(false);
            matchScreen.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Tournament") == 1)
        {
            mainMenu.SetActive(false);
            tournamentScreen.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Debug.Log("Exit game");
        PlayerPrefs.SetInt("Training", 0);
        PlayerPrefs.SetInt("LeagueMatch", 0);
        PlayerPrefs.SetInt("Tournament", 0);
        Application.Quit();
    }
    public void LoadTraining(string text)
    {
        DataTransmissionScript.gate = text;
        SceneManager.LoadScene("TrainingTrack");
    }
    public void LoadMatchHome()
    {
        if (homeTeam.options[homeTeam.value].text == awayTeam.options[awayTeam.value].text)
        {
            errorText.SetActive(true);
        }
        else
        {
            DataTransmissionScript.homeTeam = homeTeam.options[homeTeam.value].text;
            DataTransmissionScript.awayTeam = awayTeam.options[awayTeam.value].text;
            DataTransmissionScript.playerTeam = homeTeam.options[homeTeam.value].text;
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.lineCounter = 0;
            for (int i = 0; i < leagueMatchesProgrammes.Length; i++)
            {
                if(DataTransmissionScript.homeTeam + DataTransmissionScript.awayTeam == leagueMatchesProgrammes[i].name)
                {
                    DataTransmissionScript.programme = leagueMatchesProgrammes[i];
                }
            }
            matchScreen.SetActive(true);
            matchSelection.SetActive(false);
            LeaguePoints.SetActive(false);
            LeagueNextHeatButton.SetActive(false);
            LeagueNextResultButton.SetActive(true);
            HomeTeamHeatScore.SetActive(false);
            AwayTeamHeatScore.SetActive(false);
        }
    }
    public void LoadMatchAway()
    {
        if (homeTeam.options[homeTeam.value].text == awayTeam.options[awayTeam.value].text)
        {
            errorText.SetActive(true);
        }
        else
        {
            DataTransmissionScript.homeTeam = homeTeam.options[homeTeam.value].text;
            DataTransmissionScript.awayTeam = awayTeam.options[awayTeam.value].text;
            DataTransmissionScript.playerTeam = awayTeam.options[awayTeam.value].text;
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.lineCounter = 0;
            for (int i = 0; i < leagueMatchesProgrammes.Length; i++)
            {
                if (DataTransmissionScript.homeTeam + DataTransmissionScript.awayTeam == leagueMatchesProgrammes[i].name)
                {
                    DataTransmissionScript.programme = leagueMatchesProgrammes[i];
                }
            }
            matchScreen.SetActive(true);
            matchSelection.SetActive(false);
            LeaguePoints.SetActive(false);
            LeagueNextHeatButton.SetActive(false);
            LeagueNextResultButton.SetActive(true);
            HomeTeamHeatScore.SetActive(false);
            AwayTeamHeatScore.SetActive(false);
        }
    }
    public void CheckLeagueLoadGame()
    {
        if (DataTransmissionScript.leagueActive == 1)
        {
            leaguePanel.SetActive(true);
        }
        else
        {
            leagueSelection.SetActive(true);
        }
    }
    public void LoadTournament()
    {
        DataTransmissionScript.playerRider = riderSelection.options[riderSelection.value].text;
        DataTransmissionScript.tournamentTrack = trackSelection.options[trackSelection.value].text.Replace(" ", "");
        DataTransmissionScript.heatCounter = 1;
        DataTransmissionScript.lineCounter = 0;
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
        for (int i = 0; i < tournamentProgrammes.Length; i++)
        {
            if (DataTransmissionScript.tournamentTrack == tournamentProgrammes[i].name)
            {
                DataTransmissionScript.programme = tournamentProgrammes[i];
            }
        }
        tournamentScreen.SetActive(true);
        tournamentSelection.SetActive(false);
        Points.SetActive(false);
        NextHeatButton.SetActive(false);
        NextResultButton.SetActive(true);
    }
    public void NewLeagueGame()
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
    public void StartNewLeagueGame()
    {
        PlayerPrefs.SetInt("LeagueActive", 1);
        PlayerPrefs.SetString("LeagueTeam", leagueTeam.options[leagueTeam.value].text);
        DataTransmissionScript.leagueActive = PlayerPrefs.GetInt("LeagueActive");

    }
    public void CheckGPLoadGame()
    {
        if (DataTransmissionScript.GPActive == 1)
        {
            GPSeasonPanel.SetActive(true);
        }
        else
        {
            GPSeasonSelection.SetActive(true);
        }
    }
    public void NewGPGame()
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
        PlayerPrefs.SetString("GPRider", "");
        PlayerPrefs.SetInt("CurrentRound", 1);
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
    }
    public void StartNewGPGame()
    {
        PlayerPrefs.SetInt("GPActive", 1);
        PlayerPrefs.SetString("GPRider", GPRider.options[GPRider.value].text);
        DataTransmissionScript.GPActive = PlayerPrefs.GetInt("GPActive");
    }
}
