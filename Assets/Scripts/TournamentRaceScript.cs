using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TournamentRaceScript : MonoBehaviour
{
    public GameObject gateOneAI;
    public GameObject gateOnePlayer;
    public GameObject gateTwoAI;
    public GameObject gateTwoPlayer;
    public GameObject gateThreeAI;
    public GameObject gateThreePlayer;
    public GameObject gateFourAI;
    public GameObject gateFourPlayer;
    public GameObject SFXStale;
    public GameObject SFXStart;
    public string selectedGate;
    // Start is called before the first frame update
    void Start()
    {
        selectedGate = DataTransmissionScript.gate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("Red").SetActive(false);
            GameObject.Find("Blue").SetActive(false);
            GameObject.Find("White").SetActive(false);
            GameObject.Find("Yellow").SetActive(false);
            switch (selectedGate)
            {
                case "GateOne":
                    gateOnePlayer.SetActive(true);
                    gateTwoAI.SetActive(true);
                    gateThreeAI.SetActive(true);
                    gateFourAI.SetActive(true);
                    break;
                case "GateTwo":
                    gateOneAI.SetActive(true);
                    gateTwoPlayer.SetActive(true);
                    gateThreeAI.SetActive(true);
                    gateFourAI.SetActive(true);
                    break;
                case "GateThree":
                    gateOneAI.SetActive(true);
                    gateTwoAI.SetActive(true);
                    gateThreePlayer.SetActive(true);
                    gateFourAI.SetActive(true);
                    break;
                case "GateFour":
                    gateOneAI.SetActive(true);
                    gateTwoAI.SetActive(true);
                    gateThreeAI.SetActive(true);
                    gateFourPlayer.SetActive(true);
                    break;
            }
            SFXStale.SetActive(false);
            SFXStart.SetActive(true);
        }
    }
    public void LoadMainMenu()
    {
        PlayerPrefs.SetInt("Tournament", 1);
        SceneManager.LoadScene("MenuScene");
    }
}
