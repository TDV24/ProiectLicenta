using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeagueRaceScript : MonoBehaviour
{
    public GameObject Type1;
    public GameObject Type2;
    public GameObject gateOneRedAI;
    public GameObject gateOneRedPlayer;
    public GameObject gateOneYellowAI;
    public GameObject gateOneYellowPlayer;
    public GameObject gateTwoRedAI;
    public GameObject gateTwoRedPlayer;
    public GameObject gateTwoYellowAI;
    public GameObject gateTwoYellowPlayer;
    public GameObject gateThreeBlueAI;
    public GameObject gateThreeBluePlayer;
    public GameObject gateThreeWhiteAI;
    public GameObject gateThreeWhitePlayer;
    public GameObject gateFourBlueAI;
    public GameObject gateFourBluePlayer;
    public GameObject gateFourWhiteAI;
    public GameObject gateFourWhitePlayer;
    public GameObject SFXStale;
    public GameObject SFXStart;
    public string selectedGate;

    // Start is called before the first frame update
    void Start()
    {
        selectedGate = DataTransmissionScript.gate;
        if(DataTransmissionScript.heatCounter % 2 == 0)
        {
            Type1.SetActive(false);
            Type2.SetActive(true);
        }
        else
        {
            Type1.SetActive(true);
            Type2.SetActive(false);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (DataTransmissionScript.heatCounter % 2 == 0)
            {
                switch (selectedGate)
                {
                    case "GateOne":
                        gateOneYellowPlayer.SetActive(true);
                        gateTwoRedAI.SetActive(true);
                        gateThreeWhiteAI.SetActive(true);
                        gateFourBlueAI.SetActive(true);
                        break;
                    case "GateTwo":
                        gateOneYellowAI.SetActive(true);
                        gateTwoRedPlayer.SetActive(true);
                        gateThreeWhiteAI.SetActive(true);
                        gateFourBlueAI.SetActive(true);
                        break;
                    case "GateThree":
                        gateOneYellowAI.SetActive(true);
                        gateTwoRedAI.SetActive(true);
                        gateThreeWhitePlayer.SetActive(true);
                        gateFourBlueAI.SetActive(true);
                        break;
                    case "GateFour":
                        gateOneYellowAI.SetActive(true);
                        gateTwoRedAI.SetActive(true);
                        gateThreeWhiteAI.SetActive(true);
                        gateFourBluePlayer.SetActive(true);
                        break;
                }
                Type2.SetActive(false);
                SFXStale.SetActive(false);
                SFXStart.SetActive(true);
            }
            else
            {
                switch (selectedGate)
                {
                    case "GateOne":
                        gateOneRedPlayer.SetActive(true);
                        gateTwoYellowAI.SetActive(true);
                        gateThreeBlueAI.SetActive(true);
                        gateFourWhiteAI.SetActive(true);
                        break;
                    case "GateTwo":
                        gateOneRedAI.SetActive(true);
                        gateTwoYellowPlayer.SetActive(true);
                        gateThreeBlueAI.SetActive(true);
                        gateFourWhiteAI.SetActive(true);
                        break;
                    case "GateThree":
                        gateOneRedAI.SetActive(true);
                        gateTwoYellowAI.SetActive(true);
                        gateThreeBluePlayer.SetActive(true);
                        gateFourWhiteAI.SetActive(true);
                        break;
                    case "GateFour":
                        gateOneRedAI.SetActive(true);
                        gateTwoYellowAI.SetActive(true);
                        gateThreeBlueAI.SetActive(true);
                        gateFourWhitePlayer.SetActive(true);
                        break;
                }
                Type1.SetActive(false);
                SFXStale.SetActive(false);
                SFXStart.SetActive(true);
            }
        }
    }
    public void LoadMainMenu()
    {
        PlayerPrefs.SetInt("LeagueMatch", 1);
        SceneManager.LoadScene("MenuScene");
    }
}
