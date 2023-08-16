using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MotorbikeControllerTournament : MonoBehaviour
{
    public float drift = 0.95f;
    public float acceleration = 3.0f;
    public float turn = 1.5f;
    public float maxSpeed = 20.0f;
    public GameObject pilot;
    public GameObject finish;
    public TMP_Text lapCount;
    public TMP_Text rank1;
    public TMP_Text rank2;
    public TMP_Text rank3;
    public TMP_Text rank4;
    float accelerationInput = 0;
    float steeringInput = 0;
    float rotationAngle = 0;
    float velocityVsUp = 0;
    int lapCountdown = 0;

    Rigidbody2D motorbikeRigidbody2D;
    void Start()
    {
        rotationAngle = transform.rotation.eulerAngles.z;
    }

    //Awake is called when the script instance is being loaded.
    void Awake()
    {
        motorbikeRigidbody2D = GetComponent<Rigidbody2D>();
    }

    //Frame-rate independent for physics calculations.
    void FixedUpdate()
    {
        ApplyEngineForce();

        KillOrthogonalVelocity();

        ApplySteering();
    }

    private void LapsAndFinish()
    {
        if (lapCountdown > 4)
        {
            maxSpeed = 0;
            turn = 0;
            acceleration = 0;
            int activeRiders = 0;
            GameObject[] AIs = GameObject.FindGameObjectsWithTag("AI");
            GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
            activeRiders = AIs.Length + Players.Length;
            if (pilot.tag == "Player")
            {
                if (activeRiders == 4)
                {
                    switch (pilot.name)
                    {
                        case "GateOnePlayer":
                            rank1.text = "Red";
                            rank1.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateOne = 3;
                            break;
                        case "GateTwoPlayer":
                            rank1.text = "Blue";
                            rank1.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateTwo = 3;
                            break;
                        case "GateThreePlayer":
                            rank1.text = "White";
                            rank1.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateThree = 3;
                            break;
                        case "GateFourPlayer":
                            rank1.text = "Yellow";
                            rank1.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateFour = 3;
                            break;
                    }
                }
                if (activeRiders == 3)
                {
                    switch (pilot.name)
                    {
                        case "GateOnePlayer":
                            rank2.text = "Red";
                            rank2.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateOne = 2;
                            break;
                        case "GateTwoPlayer":
                            rank2.text = "Blue";
                            rank2.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateTwo = 2;
                            break;
                        case "GateThreePlayer":
                            rank2.text = "White";
                            rank2.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateThree = 2;
                            break;
                        case "GateFourPlayer":
                            rank2.text = "Yellow";
                            rank2.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateFour = 2;
                            break;
                    }
                }
                if (activeRiders == 2)
                {
                    switch (pilot.name)
                    {
                        case "GateOnePlayer":
                            rank3.text = "Red";
                            rank3.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateOne = 1;
                            break;
                        case "GateTwoPlayer":
                            rank3.text = "Blue";
                            rank3.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateTwo = 1;
                            break;
                        case "GateThreePlayer":
                            rank3.text = "White";
                            rank3.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateThree = 1;
                            break;
                        case "GateFourPlayer":
                            rank3.text = "Yellow";
                            rank3.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateFour = 1;
                            break;
                    }
                }
                if (activeRiders == 1)
                {
                    switch (pilot.name)
                    {
                        case "GateOnePlayer":
                            rank4.text = "Red";
                            rank4.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateOne = 0;
                            break;
                        case "GateTwoPlayer":
                            rank4.text = "Blue";
                            rank4.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateTwo = 0;
                            break;
                        case "GateThreePlayer":
                            rank4.text = "White";
                            rank4.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateThree = 0;
                            break;
                        case "GateFourPlayer":
                            rank4.text = "Yellow";
                            rank4.color = new Color32(255, 148, 0, 255);
                            DataTransmissionScript.pointsGateFour = 0;
                            break;
                    }
                    finish.SetActive(true);
                }
                pilot.tag = "Untagged";
            }
            if (pilot.tag == "AI")
            {
                if (activeRiders == 4)
                {
                    switch (pilot.name)
                    {
                        case "GateOneAI":
                            rank1.text = "Red";
                            DataTransmissionScript.pointsGateOne = 3;
                            break;
                        case "GateTwoAI":
                            rank1.text = "Blue";
                            DataTransmissionScript.pointsGateTwo = 3;
                            break;
                        case "GateThreeAI":
                            rank1.text = "White";
                            DataTransmissionScript.pointsGateThree = 3;
                            break;
                        case "GateFourAI":
                            rank1.text = "Yellow";
                            DataTransmissionScript.pointsGateFour = 3;
                            break;
                    }
                }
                if (activeRiders == 3)
                {
                    switch (pilot.name)
                    {
                        case "GateOneAI":
                            rank2.text = "Red";
                            DataTransmissionScript.pointsGateOne = 2;
                            break;
                        case "GateTwoAI":
                            rank2.text = "Blue";
                            DataTransmissionScript.pointsGateTwo = 2;
                            break;
                        case "GateThreeAI":
                            rank2.text = "White";
                            DataTransmissionScript.pointsGateThree = 2;
                            break;
                        case "GateFourAI":
                            rank2.text = "Yellow";
                            DataTransmissionScript.pointsGateFour = 2;
                            break;
                    }
                }
                if (activeRiders == 2)
                {
                    switch (pilot.name)
                    {
                        case "GateOneAI":
                            rank3.text = "Red";
                            DataTransmissionScript.pointsGateOne = 1;
                            break;
                        case "GateTwoAI":
                            rank3.text = "Blue";
                            DataTransmissionScript.pointsGateTwo = 1;
                            break;
                        case "GateThreeAI":
                            rank3.text = "White";
                            DataTransmissionScript.pointsGateThree = 1;
                            break;
                        case "GateFourAI":
                            rank3.text = "Yellow";
                            DataTransmissionScript.pointsGateFour = 1;
                            break;
                    }
                }
                if (activeRiders == 1)
                {
                    switch (pilot.name)
                    {
                        case "GateOneAI":
                            rank4.text = "Red";
                            DataTransmissionScript.pointsGateOne = 0;
                            break;
                        case "GateTwoAI":
                            rank4.text = "Blue";
                            DataTransmissionScript.pointsGateTwo = 0;
                            break;
                        case "GateThreeAI":
                            rank4.text = "White";
                            DataTransmissionScript.pointsGateThree = 0;
                            break;
                        case "GateFourAI":
                            rank4.text = "Yellow";
                            DataTransmissionScript.pointsGateFour = 0;
                            break;
                    }
                    finish.SetActive(true);
                }
                pilot.tag = "Untagged";
            }
        }
    }

    void ApplyEngineForce()
    {
        //stop if the acceleration button is no longer pressed
        if (accelerationInput == 0)
            motorbikeRigidbody2D.drag = Mathf.Lerp(motorbikeRigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        else motorbikeRigidbody2D.drag = 0;

        //Caculate how much we are going forward
        velocityVsUp = Vector2.Dot(transform.up, motorbikeRigidbody2D.velocity);

        //Limit so we cannot have a speed higher than the maxSpeed we set
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        //Limit so we cannot go back, only brake
        if (accelerationInput < 0)
            return;

        //Limit so we cannot go faster in any direction while accelerating
        if (motorbikeRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        //Create a force for the engine
        Vector2 engineForceVector = transform.up * accelerationInput * acceleration;

        //Apply force and pushes the car forward
        motorbikeRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteering()
    {
        //Don't make the bikes turn so much when they are not accelerating
        float minSpeedBeforeAllowTurningFactor = (motorbikeRigidbody2D.velocity.magnitude / 2);
        minSpeedBeforeAllowTurningFactor = Mathf.Clamp01(minSpeedBeforeAllowTurningFactor);

        //Update the rotation angle based on input
        rotationAngle -= steeringInput * turn * minSpeedBeforeAllowTurningFactor;

        //Apply steering
        motorbikeRigidbody2D.MoveRotation(rotationAngle);
    }

    void KillOrthogonalVelocity()
    {
        //Get forward and right velocity of the bike
        Vector2 forwardVelocity = transform.up * Vector2.Dot(motorbikeRigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(motorbikeRigidbody2D.velocity, transform.right);

        //Kill the orthogonal velocity as much as the bike can drift 
        motorbikeRigidbody2D.velocity = forwardVelocity + rightVelocity * drift;
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }

    public float GetVelocityMagnitude()
    {
        return motorbikeRigidbody2D.velocity.magnitude;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bend")
        {
            pilot.transform.GetChild(2).gameObject.SetActive(false);
            pilot.transform.GetChild(3).gameObject.SetActive(true); 
        }
        if (collision.tag == "Grass")
        {
            maxSpeed = 0.5f;
            acceleration = 0.1f;
            pilot.transform.GetChild(1).gameObject.SetActive(false);
        }
        if (collision.tag == "FinishLine" && pilot.tag == "AI")
        {
            lapCountdown++;
            LapsAndFinish();
        }
        if (collision.tag == "FinishLine" && pilot.tag == "Player")
        {
            lapCountdown++;
            if (lapCountdown > 4)
            {
                lapCount.text = (lapCountdown - 1).ToString();
            }
            else
            {
                lapCount.text = lapCountdown.ToString();
            }
            LapsAndFinish();
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Bend")
        {
            pilot.transform.GetChild(3).gameObject.SetActive(false);
            pilot.transform.GetChild(2).gameObject.SetActive(true);
        }
        if(collision.tag == "Grass")
        {
            maxSpeed = 20.0f;
            acceleration = 10.0f;
            pilot.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}