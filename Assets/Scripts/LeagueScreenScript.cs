using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeagueScreenScript : MonoBehaviour
{
    public string playerTeam;
    public GameObject LeagueScreen;
    public GameObject LeagueMatchScreen;
    public GameObject Points;
    public GameObject NextHeatButton;
    public GameObject NextResultButton;
    public GameObject HomeTeamHeatScore;
    public GameObject AwayTeamHeatScore;
    public TMP_Text HomeTeam;
    public TMP_Text AwayTeam;
    public TMP_Text Rank1Team;
    public TMP_Text Rank2Team;
    public TMP_Text Rank3Team;
    public TMP_Text Rank4Team;
    public TMP_Text Rank5Team;
    public TMP_Text Rank6Team;
    public TMP_Text Rank7Team;
    public TMP_Text Rank8Team;
    public TMP_Text Rank1Points;
    public TMP_Text Rank2Points;
    public TMP_Text Rank3Points;
    public TMP_Text Rank4Points;
    public TMP_Text Rank5Points;
    public TMP_Text Rank6Points;
    public TMP_Text Rank7Points;
    public TMP_Text Rank8Points;
    public TextAsset HomeTeams;
    public TextAsset AwayTeams;
    public TextAsset[] leagueMatchesProgrammes;
    int leagueLineCounter;
    string[] homeTeams;
    string[] awayTeams;
    string homeTeam;
    string awayTeam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTeam = PlayerPrefs.GetString("LeagueTeam");
        leagueLineCounter = DataTransmissionScript.leagueLineCounter;
        homeTeams = HomeTeams.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        awayTeams = AwayTeams.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
        homeTeam = homeTeams[leagueLineCounter];
        awayTeam = awayTeams[leagueLineCounter];
        HomeTeam.text = homeTeam.ToUpper();
        AwayTeam.text = awayTeam.ToUpper();
        OrderStandings();
    }
    public void NextMatch()
    {
        if(homeTeam != "END" && awayTeam != "END")
        {
            if(homeTeam != playerTeam && awayTeam != playerTeam) 
            {
                int homeTeamRandomScore = new System.Random().Next(15, 76);
                if (homeTeamRandomScore < 45)
                {
                    int score = PlayerPrefs.GetInt(awayTeam);
                    PlayerPrefs.SetInt(awayTeam, score + 2);
                }
                if (homeTeamRandomScore > 45)
                {
                    int score = PlayerPrefs.GetInt(homeTeam);
                    PlayerPrefs.SetInt(homeTeam, score + 2);
                }
                if (homeTeamRandomScore == 45)
                {
                    int score = PlayerPrefs.GetInt(homeTeam);
                    int score1 = PlayerPrefs.GetInt(awayTeam);
                    PlayerPrefs.SetInt(homeTeam, score + 1);
                    PlayerPrefs.SetInt(awayTeam, score1 + 1);
                }
                DataTransmissionScript.leagueLineCounter++;
                PlayerPrefs.SetInt("LeagueLineCounter", DataTransmissionScript.leagueLineCounter);
            }
            if(homeTeam == playerTeam || awayTeam == playerTeam)
            {
                DataTransmissionScript.homeTeam = homeTeam;
                DataTransmissionScript.awayTeam = awayTeam;
                DataTransmissionScript.playerTeam = playerTeam;
                DataTransmissionScript.heatCounter = 1;
                DataTransmissionScript.lineCounter = 0;
                DataTransmissionScript.sentFromLeague = 1;
                for (int i = 0; i < leagueMatchesProgrammes.Length; i++)
                {
                    if (DataTransmissionScript.homeTeam + DataTransmissionScript.awayTeam == leagueMatchesProgrammes[i].name)
                    {
                        DataTransmissionScript.programme = leagueMatchesProgrammes[i];
                    }
                }
                Points.SetActive(false);
                NextHeatButton.SetActive(false);
                NextResultButton.SetActive(true);
                HomeTeamHeatScore.SetActive(false);
                AwayTeamHeatScore.SetActive(false);
                LeagueMatchScreen.SetActive(true);
                LeagueScreen.SetActive(false);
            }
        }
    }
    public void OrderStandings()
    {
        string[] teams = { "Goats", "Hammers", "Lions", "Angels", "Warriors", "Bulls", "Gulls", "Wolves" };
        int[] teamPoints = { PlayerPrefs.GetInt("Goats"), PlayerPrefs.GetInt("Hammers"), PlayerPrefs.GetInt("Lions"),
        PlayerPrefs.GetInt("Angels"), PlayerPrefs.GetInt("Warriors"), PlayerPrefs.GetInt("Bulls"),
        PlayerPrefs.GetInt("Gulls"), PlayerPrefs.GetInt("Wolves")};
        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = i + 1; j < teams.Length; j++)
            {
                if (teamPoints[i] < teamPoints[j])
                {
                    string aux;
                    int aux1;
                    aux = teams[i];
                    teams[i] = teams[j];
                    teams[j] = aux;
                    aux1 = teamPoints[i];
                    teamPoints[i] = teamPoints[j];
                    teamPoints[j] = aux1;
                }
            }
        }
        if (teams[0] == playerTeam)
        {
            Rank1Team.color = new Color32(255, 148, 0, 255);
            Rank1Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank1Team.color = new Color32(255, 255, 255, 255);
            Rank1Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[1] == playerTeam)
        {
            Rank2Team.color = new Color32(255, 148, 0, 255);
            Rank2Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank2Team.color = new Color32(255, 255, 255, 255);
            Rank2Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[2] == playerTeam)
        {
            Rank3Team.color = new Color32(255, 148, 0, 255);
            Rank3Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank3Team.color = new Color32(255, 255, 255, 255);
            Rank3Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[3] == playerTeam)
        {
            Rank4Team.color = new Color32(255, 148, 0, 255);
            Rank4Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank4Team.color = new Color32(255, 255, 255, 255);
            Rank4Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[4] == playerTeam)
        {
            Rank5Team.color = new Color32(255, 148, 0, 255);
            Rank5Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank5Team.color = new Color32(255, 255, 255, 255);
            Rank5Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[5] == playerTeam)
        {
            Rank6Team.color = new Color32(255, 148, 0, 255);
            Rank6Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank6Team.color = new Color32(255, 255, 255, 255);
            Rank6Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[6] == playerTeam)
        {
            Rank7Team.color = new Color32(255, 148, 0, 255);
            Rank7Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank7Team.color = new Color32(255, 255, 255, 255);
            Rank7Points.color = new Color32(255, 255, 255, 255);
        }
        if (teams[7] == playerTeam)
        {
            Rank8Team.color = new Color32(255, 148, 0, 255);
            Rank8Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank8Team.color = new Color32(255, 255, 255, 255);
            Rank8Points.color = new Color32(255, 255, 255, 255);
        }
        Rank1Team.text = teams[0];
        Rank1Points.text = teamPoints[0].ToString();
        Rank2Team.text = teams[1];
        Rank2Points.text = teamPoints[1].ToString();
        Rank3Team.text = teams[2];
        Rank3Points.text = teamPoints[2].ToString();
        Rank4Team.text = teams[3];
        Rank4Points.text = teamPoints[3].ToString();
        Rank5Team.text = teams[4];
        Rank5Points.text = teamPoints[4].ToString();
        Rank6Team.text = teams[5];
        Rank6Points.text = teamPoints[5].ToString();
        Rank7Team.text = teams[6];
        Rank7Points.text = teamPoints[6].ToString();
        Rank8Team.text = teams[7];
        Rank8Points.text = teamPoints[7].ToString();
    }
}
