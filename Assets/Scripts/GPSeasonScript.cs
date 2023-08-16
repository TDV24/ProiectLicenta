using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GPSeasonScript : MonoBehaviour
{
    public string playerGPRider;
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
    public TMP_Text NextRoundName;
    public TextAsset[] tournamentProgrammes;
    public GameObject Points;
    public GameObject NextHeatButton;
    public GameObject NextResultButton;
    public GameObject GPSeasonScreen;
    public GameObject TournamentScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerGPRider = PlayerPrefs.GetString("GPRider");
        OrderStandings();
        ChangeNextRace();
    }
    public void OrderStandings()
    {
        string[] riders = { "Bart Zmiaczek", "Loen Maesen", "Makij Janik", "Fried Miedgren", "Rob Blam", "David Bangly", "Prat Kudka",
        "Teu Wuff", "Miarten Vakli", "Jimi Dyola", "Mikki Mikkel", "Jackson Holeson", "Maxi Firke", "Andron Thom", "Kjal Niasson", "Andij Liewed"};
        int[] riderPoints = { PlayerPrefs.GetInt("Bart Zmiaczek"), PlayerPrefs.GetInt("Loen Maesen"),
        PlayerPrefs.GetInt("Makij Janik"), PlayerPrefs.GetInt("Fried Miedgren"), PlayerPrefs.GetInt("Rob Blam"),
        PlayerPrefs.GetInt("David Bangly"), PlayerPrefs.GetInt("Prat Kudka"), PlayerPrefs.GetInt("Teu Wuff"),
        PlayerPrefs.GetInt("Miarten Vakli"), PlayerPrefs.GetInt("Jimi Dyola"), PlayerPrefs.GetInt("Mikki Mikkel"),
        PlayerPrefs.GetInt("Jackson Holeson"), PlayerPrefs.GetInt("Maxi Firke"), PlayerPrefs.GetInt("Andron Thom"),
        PlayerPrefs.GetInt("Kjal Niasson"), PlayerPrefs.GetInt("Andij Liewed")};
        for (int i = 0; i < riders.Length - 1; i++)
        {
            for (int j = i + 1; j < riders.Length; j++)
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
        if (riders[0] == playerGPRider)
        {
            Rank1Rider.color = new Color32(255, 148, 0, 255);
            Rank1Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank1Rider.color = new Color32(255, 255, 255, 255);
            Rank1Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[1] == playerGPRider)
        {
            Rank2Rider.color = new Color32(255, 148, 0, 255);
            Rank2Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank2Rider.color = new Color32(255, 255, 255, 255);
            Rank2Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[2] == playerGPRider)
        {
            Rank3Rider.color = new Color32(255, 148, 0, 255);
            Rank3Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank3Rider.color = new Color32(255, 255, 255, 255);
            Rank3Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[3] == playerGPRider)
        {
            Rank4Rider.color = new Color32(255, 148, 0, 255);
            Rank4Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank4Rider.color = new Color32(255, 255, 255, 255);
            Rank4Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[4] == playerGPRider)
        {
            Rank5Rider.color = new Color32(255, 148, 0, 255);
            Rank5Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank5Rider.color = new Color32(255, 255, 255, 255);
            Rank5Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[5] == playerGPRider)
        {
            Rank6Rider.color = new Color32(255, 148, 0, 255);
            Rank6Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank6Rider.color = new Color32(255, 255, 255, 255);
            Rank6Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[6] == playerGPRider)
        {
            Rank7Rider.color = new Color32(255, 148, 0, 255);
            Rank7Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank7Rider.color = new Color32(255, 255, 255, 255);
            Rank7Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[7] == playerGPRider)
        {
            Rank8Rider.color = new Color32(255, 148, 0, 255);
            Rank8Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank8Rider.color = new Color32(255, 255, 255, 255);
            Rank8Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[8] == playerGPRider)
        {
            Rank9Rider.color = new Color32(255, 148, 0, 255);
            Rank9Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank9Rider.color = new Color32(255, 255, 255, 255);
            Rank9Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[9] == playerGPRider)
        {
            Rank10Rider.color = new Color32(255, 148, 0, 255);
            Rank10Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank10Rider.color = new Color32(255, 255, 255, 255);
            Rank10Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[10] == playerGPRider)
        {
            Rank11Rider.color = new Color32(255, 148, 0, 255);
            Rank11Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank11Rider.color = new Color32(255, 255, 255, 255);
            Rank11Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[11] == playerGPRider)
        {
            Rank12Rider.color = new Color32(255, 148, 0, 255);
            Rank12Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank12Rider.color = new Color32(255, 255, 255, 255);
            Rank12Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[12] == playerGPRider)
        {
            Rank13Rider.color = new Color32(255, 148, 0, 255);
            Rank13Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank13Rider.color = new Color32(255, 255, 255, 255);
            Rank13Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[13] == playerGPRider)
        {
            Rank14Rider.color = new Color32(255, 148, 0, 255);
            Rank14Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank14Rider.color = new Color32(255, 255, 255, 255);
            Rank14Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[14] == playerGPRider)
        {
            Rank15Rider.color = new Color32(255, 148, 0, 255);
            Rank15Points.color = new Color32(255, 148, 0, 255);
        }
        else
        {
            Rank15Rider.color = new Color32(255, 255, 255, 255);
            Rank15Points.color = new Color32(255, 255, 255, 255);
        }
        if (riders[15] == playerGPRider)
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
    public void ChangeNextRace()
    {
        switch (PlayerPrefs.GetInt("CurrentRound"))
        {
            case 1:
                NextRoundName.text = "CROATIA";
                break;
            case 2:
                NextRoundName.text = "POLAND 1";
                break;
            case 3:
                NextRoundName.text = "CZECH REPUBLIC";
                break;
            case 4:
                NextRoundName.text = "GERMANY";
                break;
            case 5:
                NextRoundName.text = "POLAND 2";
                break;
            case 6:
                NextRoundName.text = "SWEDEN";
                break;
            case 7:
                NextRoundName.text = "LATVIA";
                break;
            case 8:
                NextRoundName.text = "GREAT BRITAIN";
                break;
            case 9:
                NextRoundName.text = "DENMARK";
                break;
            case 10:
                NextRoundName.text = "POLAND 3";
                break;
            case 11:
                NextRoundName.text = "END";
                break;
        }
    }
    public void LoadTournament()
    {
        if(PlayerPrefs.GetInt("CurrentRound") < 11)
        {
            DataTransmissionScript.playerRider = playerGPRider;
            switch (PlayerPrefs.GetInt("CurrentRound"))
            {
                case 1:
                    DataTransmissionScript.tournamentTrack = "Croatia";
                    break;
                case 2:
                    DataTransmissionScript.tournamentTrack = "Poland1";
                    break;
                case 3:
                    DataTransmissionScript.tournamentTrack = "CzechRepublic";
                    break;
                case 4:
                    DataTransmissionScript.tournamentTrack = "Germany";
                    break;
                case 5:
                    DataTransmissionScript.tournamentTrack = "Poland2";
                    break;
                case 6:
                    DataTransmissionScript.tournamentTrack = "Sweden";
                    break;
                case 7:
                    DataTransmissionScript.tournamentTrack = "Latvia";
                    break;
                case 8:
                    DataTransmissionScript.tournamentTrack = "GreatBritain";
                    break;
                case 9:
                    DataTransmissionScript.tournamentTrack = "Denmark";
                    break;
                case 10:
                    DataTransmissionScript.tournamentTrack = "Poland3";
                    break;
            }
            DataTransmissionScript.heatCounter = 1;
            DataTransmissionScript.lineCounter = 0;
            DataTransmissionScript.sentFromGP = 1;
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
            GPSeasonScreen.SetActive(false);
            TournamentScreen.SetActive(true);
            Points.SetActive(false);
            NextHeatButton.SetActive(false);
            NextResultButton.SetActive(true);
        }
    }
}
