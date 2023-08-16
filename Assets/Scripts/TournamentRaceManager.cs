using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TournamentRaceManager : MonoBehaviour
{
    public string playerRider;
    public string tournamentTrack;
    public int sentfromGP;
    public GameObject TournamentScreen;
    public GameObject TournamentSelection;
    public GameObject GPSeasonScreen;
    public GameObject Rider1Button;
    public GameObject Rider2Button;
    public GameObject Rider3Button;
    public GameObject Rider4Button;
    public GameObject NextResultButton;
    public GameObject NextHeatButton;
    public GameObject Points;
    public TMP_Text Rider1;
    public TMP_Text Rider2;
    public TMP_Text Rider3;
    public TMP_Text Rider4;
    public TMP_Text pointsRider1;
    public TMP_Text pointsRider2;
    public TMP_Text pointsRider3;
    public TMP_Text pointsRider4;
    public TextAsset programme;
    int[,] possibleOutcomes = new int[24, 4] { {0, 1, 2, 3}, {0, 1, 3, 2}, {0, 2, 1, 3}, {0, 2, 3, 1}, {0, 3, 1, 2}, {0, 3, 2, 1},
                                               {1, 0, 2, 3}, {1, 0, 3, 2}, {1, 2, 0, 3}, {1, 2, 3, 0}, {1, 3, 0, 2}, {1, 3, 2, 0},
                                               {2, 0, 1, 3}, {2, 0, 3, 1}, {2, 1, 0, 3}, {2, 1, 3, 0}, {2, 3, 0, 1}, {2, 3, 1, 0},
                                               {3, 0, 1, 2}, {3, 0, 2, 1}, {3, 1, 0, 2}, {3, 1, 2, 0}, {3, 2, 0, 1}, {3, 2, 1, 0} };
    int heatCounter = 1;
    int lineCounter = 0;
    string[] lineups;
    public TMP_Text heatNumber;
    public TMP_Text Rank1Rider;
    public TMP_Text Rank2Rider;
    public TMP_Text Rank3Rider;
    public TMP_Text Rank4Rider;
    public TMP_Text Rank5Rider;
    public TMP_Text Rank6Rider;
    public TMP_Text Rank7Rider;
    public TMP_Text Rank8Rider;
    public TMP_Text Rank9Rider;
    public TMP_Text Rank10Rider;
    public TMP_Text Rank11Rider;
    public TMP_Text Rank12Rider;
    public TMP_Text Rank13Rider;
    public TMP_Text Rank14Rider;
    public TMP_Text Rank15Rider;
    public TMP_Text Rank16Rider;
    public TMP_Text Rank1Points;
    public TMP_Text Rank2Points;
    public TMP_Text Rank3Points;
    public TMP_Text Rank4Points;
    public TMP_Text Rank5Points;
    public TMP_Text Rank6Points;
    public TMP_Text Rank7Points;
    public TMP_Text Rank8Points;
    public TMP_Text Rank9Points;
    public TMP_Text Rank10Points;
    public TMP_Text Rank11Points;
    public TMP_Text Rank12Points;
    public TMP_Text Rank13Points;
    public TMP_Text Rank14Points;
    public TMP_Text Rank15Points;
    public TMP_Text Rank16Points;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Tournament") == 1)
        {
            playerRider = DataTransmissionScript.playerRider;
            tournamentTrack = DataTransmissionScript.tournamentTrack;
            programme = DataTransmissionScript.programme;
            lineups = programme.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            lineCounter = DataTransmissionScript.lineCounter;
            heatCounter = DataTransmissionScript.heatCounter;
            sentfromGP = DataTransmissionScript.sentFromGP;
            Rider1.text = lineups[lineCounter];
            Rider2.text = lineups[lineCounter + 1];
            Rider3.text = lineups[lineCounter + 2];
            Rider4.text = lineups[lineCounter + 3];
            NextResult(DataTransmissionScript.pointsGateOne, DataTransmissionScript.pointsGateTwo,
                DataTransmissionScript.pointsGateThree, DataTransmissionScript.pointsGateFour);
            Points.SetActive(true);
            TournamentCurrentPoint();
            PlayerPrefs.SetInt("Tournament", 0);
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
        else
        {
            playerRider = DataTransmissionScript.playerRider;
            tournamentTrack = DataTransmissionScript.tournamentTrack;
            programme = DataTransmissionScript.programme;
            lineups = programme.text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            lineCounter = DataTransmissionScript.lineCounter;
            heatCounter = DataTransmissionScript.heatCounter;
            sentfromGP = DataTransmissionScript.sentFromGP;
            Rider1.text = lineups[lineCounter];
            Rider2.text = lineups[lineCounter + 1];
            Rider3.text = lineups[lineCounter + 2];
            Rider4.text = lineups[lineCounter + 3];
            TournamentCurrentPoint();
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
    public void NextResult(int points1, int points2, int points3, int points4)
    {
        pointsRider1.text = points1.ToString();
        pointsRider2.text = points2.ToString();
        pointsRider3.text = points3.ToString();
        pointsRider4.text = points4.ToString();
        int x1 = PlayerPrefs.GetInt(Rider1.text + " Tournament");
        int x2 = PlayerPrefs.GetInt(Rider2.text + " Tournament");
        int x3 = PlayerPrefs.GetInt(Rider3.text + " Tournament");
        int x4 = PlayerPrefs.GetInt(Rider4.text + " Tournament");
        PlayerPrefs.SetInt(Rider1.text + " Tournament", x1 + points1);
        PlayerPrefs.SetInt(Rider2.text + " Tournament", x2 + points2);
        PlayerPrefs.SetInt(Rider3.text + " Tournament", x3 + points3);
        PlayerPrefs.SetInt(Rider4.text + " Tournament", x4 + points4);
        NextResultButton.SetActive(false);
        NextHeatButton.SetActive(true);
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
        int x1 = PlayerPrefs.GetInt(Rider1.text + " Tournament");
        int x2 = PlayerPrefs.GetInt(Rider2.text + " Tournament");
        int x3 = PlayerPrefs.GetInt(Rider3.text + " Tournament");
        int x4 = PlayerPrefs.GetInt(Rider4.text + " Tournament");
        PlayerPrefs.SetInt(Rider1.text + " Tournament", x1 + points1);
        PlayerPrefs.SetInt(Rider2.text + " Tournament", x2 + points2);
        PlayerPrefs.SetInt(Rider3.text + " Tournament", x3 + points3);
        PlayerPrefs.SetInt(Rider4.text + " Tournament", x4 + points4);
    }
    public void NextHeat()
    {
        heatCounter++;
        DataTransmissionScript.heatCounter = heatCounter;
        DataTransmissionScript.lineCounter = lineCounter + 4;
        if(heatCounter > 20)
        {
            ExitTournament();
        }
    }
    public void TournamentCurrentPoint()
    {
        if (NextHeatButton.activeSelf)
        {
            heatNumber.text = heatCounter.ToString();
            Rider1Button.SetActive(false);
            Rider2Button.SetActive(false);
            Rider3Button.SetActive(false);
            Rider4Button.SetActive(false);
        }
        else
        {
            heatNumber.text = heatCounter.ToString();
            if (Rider1.text == playerRider)
            {
                Rider1Button.SetActive(true);
                Rider1.color = new Color32(255, 148, 0, 255);
            }
            else
            {
                Rider1Button.SetActive(false);
                Rider1.color = new Color32(255, 255, 255, 255);
            }
            if (Rider2.text == playerRider)
            {
                Rider2Button.SetActive(true);
                Rider2.color = new Color32(255, 148, 0, 255);
            }
            else
            {
                Rider2Button.SetActive(false);
                Rider2.color = new Color32(255, 255, 255, 255);
            }
            if (Rider3.text == playerRider)
            {
                Rider3Button.SetActive(true);
                Rider3.color = new Color32(255, 148, 0, 255);
            }
            else
            {
                Rider3Button.SetActive(false);
                Rider3.color = new Color32(255, 255, 255, 255);
            }
            if (Rider4.text == playerRider)
            {
                Rider4Button.SetActive(true);
                Rider4.color = new Color32(255, 148, 0, 255);
            }
            else
            {
                Rider4Button.SetActive(false);
                Rider4.color = new Color32(255, 255, 255, 255);
            }
        }
    }
    public void ExitTournament()
    {
        if(DataTransmissionScript.sentFromGP == 1)
        {
            heatCounter = 1;
            heatNumber.text = heatCounter.ToString();
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.lineCounter = 0;
            DataTransmissionScript.sentFromGP = 0;
            int c = PlayerPrefs.GetInt("CurrentRound");
            PlayerPrefs.SetInt("CurrentRound", c + 1);
            PlayerPrefs.SetInt("Bart Zmiaczek", PlayerPrefs.GetInt("Bart Zmiaczek") + PlayerPrefs.GetInt("Bart Zmiaczek Tournament"));
            PlayerPrefs.SetInt("Loen Maesen", PlayerPrefs.GetInt("Loen Maesen") + PlayerPrefs.GetInt("Loen Maesen Tournament"));
            PlayerPrefs.SetInt("Makij Janik", PlayerPrefs.GetInt("Makij Janik") + PlayerPrefs.GetInt("Makij Janik Tournament"));
            PlayerPrefs.SetInt("Fried Miedgren", PlayerPrefs.GetInt("Fried Miedgren") + PlayerPrefs.GetInt("Fried Miedgren Tournament"));
            PlayerPrefs.SetInt("Rob Blam", PlayerPrefs.GetInt("Rob Blam") + PlayerPrefs.GetInt("Rob Blam Tournament"));
            PlayerPrefs.SetInt("David Bangly", PlayerPrefs.GetInt("David Bangly") + PlayerPrefs.GetInt("David Bangly Tournament"));
            PlayerPrefs.SetInt("Prat Kudka", PlayerPrefs.GetInt("Prat Kudka") + PlayerPrefs.GetInt("Prat Kudka Tournament"));
            PlayerPrefs.SetInt("Teu Wuff", PlayerPrefs.GetInt("Teu Wuff") + PlayerPrefs.GetInt("Teu Wuff Tournament"));
            PlayerPrefs.SetInt("Miarten Vakli", PlayerPrefs.GetInt("Miarten Vakli") + PlayerPrefs.GetInt("Miarten Vakli Tournament"));
            PlayerPrefs.SetInt("Jimi Dyola", PlayerPrefs.GetInt("Jimi Dyola") + PlayerPrefs.GetInt("Jimi Dyola Tournament"));
            PlayerPrefs.SetInt("Mikki Mikkel", PlayerPrefs.GetInt("Mikki Mikkel") + PlayerPrefs.GetInt("Mikki Mikkel Tournament"));
            PlayerPrefs.SetInt("Jackson Holeson", PlayerPrefs.GetInt("Jackson Holeson") + PlayerPrefs.GetInt("Jackson Holeson Tournament"));
            PlayerPrefs.SetInt("Maxi Firke", PlayerPrefs.GetInt("Maxi Firke") + PlayerPrefs.GetInt("Maxi Firke Tournament"));
            PlayerPrefs.SetInt("Andron Thom", PlayerPrefs.GetInt("Andron Thom") + PlayerPrefs.GetInt("Andron Thom Tournament"));
            PlayerPrefs.SetInt("Kjal Niasson", PlayerPrefs.GetInt("Kjal Niasson") + PlayerPrefs.GetInt("Kjal Niasson Tournament"));
            PlayerPrefs.SetInt("Andij Liewed", PlayerPrefs.GetInt("Andij Liewed") + PlayerPrefs.GetInt("Andij Liewed Tournament"));
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
            TournamentScreen.SetActive(false);
            GPSeasonScreen.SetActive(true);
        }
        else
        {
            heatCounter = 1;
            heatNumber.text = heatCounter.ToString();
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
            TournamentScreen.SetActive(false);
            TournamentSelection.SetActive(true);
        }
    }
    public void StartHeat(string gate)
    {
        DataTransmissionScript.gate = gate;
        SceneManager.LoadScene(tournamentTrack + "Track");
    }
    public void BackExit()
    {
        if (sentfromGP == 1)
        {
            DataTransmissionScript.sentFromGP = 0;
            GPSeasonScreen.SetActive(true);
            TournamentScreen.SetActive(false);
        }
        else
        {
            TournamentScreen.SetActive(false);
            TournamentSelection.SetActive(true);
        }
    }
    public void OrderStandings()
    {
        string[] riders = { "Bart Zmiaczek", "Loen Maesen", "Makij Janik", "Fried Miedgren", "Rob Blam", "David Bangly", "Prat Kudka",
        "Teu Wuff", "Miarten Vakli", "Jimi Dyola", "Mikki Mikkel", "Jackson Holeson", "Maxi Firke", "Andron Thom", "Kjal Niasson", "Andij Liewed"};
        int[] riderPoints = { DataTransmissionScript.BartZmiaczekPointsTournament, DataTransmissionScript.LoenMaesenPointsTournament,
        DataTransmissionScript.MakijJanikPointsTournament, DataTransmissionScript.FriedMiedgrenPointsTournament, DataTransmissionScript.RobBlamPointsTournament,
        DataTransmissionScript.DavidBanglyPointsTournament, DataTransmissionScript.PratKudkaPointsTournament, DataTransmissionScript.TeuWuffPointsTournament,
        DataTransmissionScript.MiartenVakliPointsTournament, DataTransmissionScript.JimiDyolaPointsTournament, DataTransmissionScript.MikkiMikkelPointsTournament,
        DataTransmissionScript.JacksonHolesonPointsTournament, DataTransmissionScript.MaxiFirkePointsTournament, DataTransmissionScript.AndronThomPointsTournament,
        DataTransmissionScript.KjalNiassonPointsTournament, DataTransmissionScript.AndijLiewedPointsTournament};
        for(int i = 0; i < riders.Length - 1; i++)
        {
            for(int j = i + 1; j < riders.Length; j++)
            {
                if (riderPoints[i] < riderPoints[j])
                {
                    string aux;
                    int aux1;
                    aux = riders[i];
                    riders[i] = riders[j];
                    riders[j] = aux;
                    aux1 = riderPoints[i];
                    riderPoints[i] = riderPoints[j];
                    riderPoints[j] = aux1;
                }
            }
        }
        if (riders[0] == playerRider)
        {
            Rank1Rider.color = new Color32(255, 148, 0, 255);
            Rank1Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank1Rider.color = new Color32(255, 255, 255, 255);
            Rank1Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[1] == playerRider)
        {
            Rank2Rider.color = new Color32(255, 148, 0, 255);
            Rank2Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank2Rider.color = new Color32(255, 255, 255, 255);
            Rank2Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[2] == playerRider)
        {
            Rank3Rider.color = new Color32(255, 148, 0, 255);
            Rank3Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank3Rider.color = new Color32(255, 255, 255, 255);
            Rank3Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[3] == playerRider)
        {
            Rank4Rider.color = new Color32(255, 148, 0, 255);
            Rank4Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank4Rider.color = new Color32(255, 255, 255, 255);
            Rank4Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[4] == playerRider)
        {
            Rank5Rider.color = new Color32(255, 148, 0, 255);
            Rank5Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank5Rider.color = new Color32(255, 255, 255, 255);
            Rank5Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[5] == playerRider)
        {
            Rank6Rider.color = new Color32(255, 148, 0, 255);
            Rank6Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
           Rank6Rider.color = new Color32(255, 255, 255, 255);
           Rank6Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[6] == playerRider)
        {
            Rank7Rider.color = new Color32(255, 148, 0, 255);
            Rank7Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank7Rider.color = new Color32(255, 255, 255, 255);
            Rank7Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[7] == playerRider)
        {
            Rank8Rider.color = new Color32(255, 148, 0, 255);
            Rank8Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank8Rider.color = new Color32(255, 255, 255, 255);
            Rank8Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[8] == playerRider)
        {
            Rank9Rider.color = new Color32(255, 148, 0, 255);
            Rank9Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank9Rider.color = new Color32(255, 255, 255, 255);
            Rank9Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[9] == playerRider)
        {
            Rank10Rider.color = new Color32(255, 148, 0, 255);
            Rank10Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank10Rider.color = new Color32(255, 255, 255, 255);
            Rank10Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[10] == playerRider)
        {
            Rank11Rider.color = new Color32(255, 148, 0, 255);
            Rank11Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank11Rider.color = new Color32(255, 255, 255, 255);
            Rank11Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[11] == playerRider)
        {
            Rank12Rider.color = new Color32(255, 148, 0, 255);
            Rank12Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank12Rider.color = new Color32(255, 255, 255, 255);
            Rank12Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[12] == playerRider)
        {
            Rank13Rider.color = new Color32(255, 148, 0, 255);
            Rank13Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank13Rider.color = new Color32(255, 255, 255, 255);
            Rank13Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[13] == playerRider)
        {
            Rank14Rider.color = new Color32(255, 148, 0, 255);
            Rank14Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank14Rider.color = new Color32(255, 255, 255, 255);
            Rank14Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[14] == playerRider)
        {
            Rank15Rider.color = new Color32(255, 148, 0, 255);
            Rank15Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank15Rider.color = new Color32(255, 255, 255, 255);
            Rank15Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[15] == playerRider)
        {
            Rank16Rider.color = new Color32(255, 148, 0, 255);
            Rank16Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank16Rider.color = new Color32(255, 255, 255, 255);
            Rank16Points.color = new Color32(255, 255, 255, 255);
        }
        Rank1Rider.text = riders[0];
        Rank1Points.text = riderPoints[0].ToString();
        Rank2Rider.text = riders[1];
        Rank2Points.text = riderPoints[1].ToString();
        Rank3Rider.text = riders[2];
        Rank3Points.text = riderPoints[2].ToString();
        Rank4Rider.text = riders[3];
        Rank4Points.text = riderPoints[3].ToString();
        Rank5Rider.text = riders[4];
        Rank5Points.text = riderPoints[4].ToString();
        Rank6Rider.text = riders[5];
        Rank6Points.text = riderPoints[5].ToString();
        Rank7Rider.text = riders[6];
        Rank7Points.text = riderPoints[6].ToString();
        Rank8Rider.text = riders[7];
        Rank8Points.text = riderPoints[7].ToString();
        Rank9Rider.text = riders[8];
        Rank9Points.text = riderPoints[8].ToString();
        Rank10Rider.text = riders[9];
        Rank10Points.text = riderPoints[9].ToString();
        Rank11Rider.text = riders[10];
        Rank11Points.text = riderPoints[10].ToString();
        Rank12Rider.text = riders[11];
        Rank12Points.text = riderPoints[11].ToString();
        Rank13Rider.text = riders[12];
        Rank13Points.text = riderPoints[12].ToString();
        Rank14Rider.text = riders[13];
        Rank14Points.text = riderPoints[13].ToString();
        Rank15Rider.text = riders[14];
        Rank15Points.text = riderPoints[14].ToString();
        Rank16Rider.text = riders[15];
        Rank16Points.text = riderPoints[15].ToString();
    }
}
