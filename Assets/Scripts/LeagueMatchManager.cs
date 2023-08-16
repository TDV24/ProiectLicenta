using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeagueMatchManager : MonoBehaviour
{
    public string homeMatchTeam;
    public string awayMatchTeam;
    public string playerMatchTeam;
    public int sentFromLeague;
    public Image homeTeamImage;
    public Image awayTeamImage;
    public Sprite[] Logos;
    public GameObject type1;
    public GameObject type2;
    public GameObject LeagueScreen;
    public GameObject LeagueMatchScreen;
    public GameObject MainMenu;
    public GameObject Rider1Button;
    public GameObject Rider2Button;
    public GameObject Rider3Button;
    public GameObject Rider4Button;
    public GameObject NextHeatButton;
    public GameObject NextResultButton;
    public GameObject Points;
    public GameObject HomeHeatScore;
    public GameObject AwayHeatScore;
    public TMP_Text homeScore;
    public TMP_Text awayScore;
    public TMP_Text homeTeamHeatScore;
    public TMP_Text awayTeamHeatScore;
    public TMP_Text Rider1;
    public TMP_Text Rider2;
    public TMP_Text Rider3;
    public TMP_Text Rider4;
    public TMP_Text pointsRider1;
    public TMP_Text pointsRider2;
    public TMP_Text pointsRider3;
    public TMP_Text pointsRider4;
    public TextAsset programme;
    public TMP_Text heatNumber;
    int[,] possibleOutcomes = new int[24, 4] { {0, 1, 2, 3}, {0, 1, 3, 2}, {0, 2, 1, 3}, {0, 2, 3, 1}, {0, 3, 1, 2}, {0, 3, 2, 1},
                                               {1, 0, 2, 3}, {1, 0, 3, 2}, {1, 2, 0, 3}, {1, 2, 3, 0}, {1, 3, 0, 2}, {1, 3, 2, 0},
                                               {2, 0, 1, 3}, {2, 0, 3, 1}, {2, 1, 0, 3}, {2, 1, 3, 0}, {2, 3, 0, 1}, {2, 3, 1, 0},
                                               {3, 0, 1, 2}, {3, 0, 2, 1}, {3, 1, 0, 2}, {3, 1, 2, 0}, {3, 2, 0, 1}, {3, 2, 1, 0} };
    int heatCounter = 1;
    int homeTeamScore = 0;
    int awayTeamScore = 0;
    int lineCounter = 0;
    string[] lineups;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("LeagueMatch") == 1)
        {
            sentFromLeague = DataTransmissionScript.sentFromLeague;
            homeMatchTeam = DataTransmissionScript.homeTeam;
            awayMatchTeam = DataTransmissionScript.awayTeam;
            playerMatchTeam = DataTransmissionScript.playerTeam;
            heatCounter = DataTransmissionScript.heatCounter;
            homeTeamScore = DataTransmissionScript.homeTeamScore;
            awayTeamScore = DataTransmissionScript.awayTeamScore;
            programme = DataTransmissionScript.programme;
            lineCounter = DataTransmissionScript.lineCounter;
            lineups = programme.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Rider1.text = lineups[lineCounter];
            Rider2.text = lineups[lineCounter + 1];
            Rider3.text = lineups[lineCounter + 2];
            Rider4.text = lineups[lineCounter + 3];
            heatNumber.text = heatCounter.ToString();
            homeScore.text = homeTeamScore.ToString();
            awayScore.text = awayTeamScore.ToString();
            for (int i = 0; i < 8; i++)
            {
                if (Logos[i].name == homeMatchTeam)
                {
                    homeTeamImage.sprite = Logos[i];
                }
                if (Logos[i].name == awayMatchTeam)
                {
                    awayTeamImage.sprite = Logos[i];
                }
            }
            NextResult(DataTransmissionScript.pointsGateOne, DataTransmissionScript.pointsGateTwo, DataTransmissionScript.pointsGateThree,
                DataTransmissionScript.pointsGateFour);
            Points.SetActive(true);
            PlayerPrefs.SetInt("LeagueMatch", 0);
            MatchCurrentPoint();
        }
        else
        {
            sentFromLeague = DataTransmissionScript.sentFromLeague;
            homeMatchTeam = DataTransmissionScript.homeTeam;
            awayMatchTeam = DataTransmissionScript.awayTeam;
            playerMatchTeam = DataTransmissionScript.playerTeam;
            heatCounter = DataTransmissionScript.heatCounter;
            homeTeamScore = DataTransmissionScript.homeTeamScore;
            awayTeamScore = DataTransmissionScript.awayTeamScore;
            programme = DataTransmissionScript.programme;
            lineCounter = DataTransmissionScript.lineCounter;
            lineups = programme.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Rider1.text = lineups[lineCounter];
            Rider2.text = lineups[lineCounter + 1];
            Rider3.text = lineups[lineCounter + 2];
            Rider4.text = lineups[lineCounter + 3];
            heatNumber.text = heatCounter.ToString();
            homeScore.text = homeTeamScore.ToString();
            awayScore.text = awayTeamScore.ToString();
            for (int i = 0; i < 8; i++)
            {
                if (Logos[i].name == homeMatchTeam)
                {
                    homeTeamImage.sprite = Logos[i];
                }
                if (Logos[i].name == awayMatchTeam)
                {
                    awayTeamImage.sprite = Logos[i];
                }
            }
            MatchCurrentPoint();
        }
    }
    public void NextResult(int points1, int points2, int points3, int points4)
    {
        if (DataTransmissionScript.heatCounter % 2 == 0)
        {
            type1.SetActive(false);
            type2.SetActive(true);
        }
        else
        {
            type1.SetActive(true);
            type2.SetActive(false);
        }
        pointsRider1.text = points1.ToString();
        pointsRider2.text = points2.ToString();
        pointsRider3.text = points3.ToString();
        pointsRider4.text = points4.ToString();
        int heatScoreHome = 0;
        int heatScoreAway = 0;
        if (type1.activeSelf)
        {
            heatScoreHome = points1 + points3;
            heatScoreAway = points2 + points4;
        }
        else
        {
            heatScoreAway = points1 + points3;
            heatScoreHome = points2 + points4;
        }
        homeTeamScore += heatScoreHome;
        awayTeamScore += heatScoreAway;
        DataTransmissionScript.homeTeamScore = homeTeamScore;
        DataTransmissionScript.awayTeamScore = awayTeamScore;
        homeScore.text = homeTeamScore.ToString();
        awayScore.text = awayTeamScore.ToString();
        homeTeamHeatScore.text = heatScoreHome.ToString();
        awayTeamHeatScore.text = heatScoreAway.ToString();
        NextResultButton.SetActive(false);
        NextHeatButton.SetActive(true);
        HomeHeatScore.SetActive(true);
        AwayHeatScore.SetActive(true);
    }
    public void NextResult()
    {
        var random = new System.Random();
        int randomRow = random.Next(24);
        int points1 = possibleOutcomes[randomRow, 0];
        int points2 = possibleOutcomes[randomRow, 1];
        int points3 = possibleOutcomes[randomRow, 2];
        int points4 = possibleOutcomes[randomRow, 3];
        pointsRider1.text = points1.ToString();
        pointsRider2.text = points2.ToString();
        pointsRider3.text = points3.ToString();
        pointsRider4.text = points4.ToString();
        int heatScoreHome = 0;
        int heatScoreAway = 0;
        if (type1.activeSelf)
        {
            heatScoreHome = points1 + points3;
            heatScoreAway = points2 + points4;
        }
        else
        {
            heatScoreAway = points1 + points3;
            heatScoreHome = points2 + points4;
        }
        homeTeamScore += heatScoreHome;
        awayTeamScore += heatScoreAway;
        DataTransmissionScript.homeTeamScore = homeTeamScore;
        DataTransmissionScript.awayTeamScore = awayTeamScore;
        homeScore.text = homeTeamScore.ToString();
        awayScore.text = awayTeamScore.ToString();
        homeTeamHeatScore.text = heatScoreHome.ToString();
        awayTeamHeatScore.text = heatScoreAway.ToString();
    }
    public void NextHeat()
    {
        heatCounter++;
        DataTransmissionScript.heatCounter = heatCounter;
        DataTransmissionScript.lineCounter = lineCounter + 4;
        if (heatCounter > 15)
        {
            ExitMatch();
        }
    }
    public void MatchCurrentPoint()
    {
        if (NextHeatButton.activeSelf) 
        { 
            Rider1Button.SetActive(false);
            Rider2Button.SetActive(false);
            Rider3Button.SetActive(false);
            Rider4Button.SetActive(false);
        }
        else
        {
            heatNumber.text = heatCounter.ToString();
            if (heatCounter % 2 == 0)
            {
                type1.SetActive(false);
                type2.SetActive(true);
                if (playerMatchTeam == homeMatchTeam)
                {
                    Rider1Button.SetActive(false);
                    Rider1.color = new Color32(255, 255, 255, 255);
                    Rider2Button.SetActive(true);
                    Rider2.color = new Color32(255, 148, 0, 255);
                    Rider3Button.SetActive(false);
                    Rider3.color = new Color32(255, 255, 255, 255);
                    Rider4Button.SetActive(true);
                    Rider4.color = new Color32(255, 148, 0, 255);
                }
                else
                {
                    Rider1Button.SetActive(true);
                    Rider1.color = new Color32(255, 148, 0, 255);
                    Rider2Button.SetActive(false);
                    Rider2.color = new Color32(255, 255, 255, 255);
                    Rider3Button.SetActive(true);
                    Rider3.color = new Color32(255, 148, 0, 255);
                    Rider4Button.SetActive(false);
                    Rider4.color = new Color32(255, 255, 255, 255);
                }
            }
            else
            {
                type2.SetActive(false);
                type1.SetActive(true);
                if (playerMatchTeam == homeMatchTeam)
                {
                    Rider1Button.SetActive(true);
                    Rider1.color = new Color32(255, 148, 0, 255);
                    Rider2Button.SetActive(false);
                    Rider2.color = new Color32(255, 255, 255, 255);
                    Rider3Button.SetActive(true);
                    Rider3.color = new Color32(255, 148, 0, 255);
                    Rider4Button.SetActive(false);
                    Rider4.color = new Color32(255, 255, 255, 255);
                }
                else
                {
                    Rider1Button.SetActive(false);
                    Rider1.color = new Color32(255, 255, 255, 255);
                    Rider2Button.SetActive(true);
                    Rider2.color = new Color32(255, 148, 0, 255);
                    Rider3Button.SetActive(false);
                    Rider3.color = new Color32(255, 255, 255, 255);
                    Rider4Button.SetActive(true);
                    Rider4.color = new Color32(255, 148, 0, 255);
                }
            }
        }
    }
    public void ExitMatch()
    {
        if(sentFromLeague == 1)
        {
            if (homeTeamScore < 45 && heatCounter > 15)
            {
                int score = PlayerPrefs.GetInt(awayMatchTeam);
                PlayerPrefs.SetInt(awayMatchTeam, score + 2);
                DataTransmissionScript.leagueLineCounter++;
                PlayerPrefs.SetInt("LeagueLineCounter", DataTransmissionScript.leagueLineCounter);
            }
            if (homeTeamScore > 45 && heatCounter > 15)
            {
                int score = PlayerPrefs.GetInt(homeMatchTeam);
                PlayerPrefs.SetInt(homeMatchTeam, score + 2);
                DataTransmissionScript.leagueLineCounter++;
                PlayerPrefs.SetInt("LeagueLineCounter", DataTransmissionScript.leagueLineCounter);
            }
            if (homeTeamScore == 45 && heatCounter > 15)
            {
                int score = PlayerPrefs.GetInt(homeMatchTeam);
                int score1 = PlayerPrefs.GetInt(awayMatchTeam);
                PlayerPrefs.SetInt(homeMatchTeam, score + 1);
                PlayerPrefs.SetInt(awayMatchTeam, score1 + 1);
                DataTransmissionScript.leagueLineCounter++;
                PlayerPrefs.SetInt("LeagueLineCounter", DataTransmissionScript.leagueLineCounter);
            }
            DataTransmissionScript.sentFromLeague = 0;
            heatCounter = 1;
            heatNumber.text = heatCounter.ToString();
            homeTeamScore = 0;
            awayTeamScore = 0;
            homeScore.text = homeTeamScore.ToString();
            awayScore.text = awayTeamScore.ToString();
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.homeTeamScore = 0;
            DataTransmissionScript.awayTeamScore = 0;
            DataTransmissionScript.lineCounter = 0;
            LeagueMatchScreen.SetActive(false);
            LeagueScreen.SetActive(true);
        }
        else
        {
            heatCounter = 1;
            heatNumber.text = heatCounter.ToString();
            homeTeamScore = 0;
            awayTeamScore = 0;
            homeScore.text = homeTeamScore.ToString();
            awayScore.text = awayTeamScore.ToString();
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.homeTeamScore = 0;
            DataTransmissionScript.awayTeamScore = 0;
            DataTransmissionScript.lineCounter = 0;
            LeagueMatchScreen.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
    public void StartHeat(string gate)
    {
        DataTransmissionScript.gate = gate;
        SceneManager.LoadScene(homeMatchTeam + "Track");
    }
}
