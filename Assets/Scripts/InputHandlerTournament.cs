using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerTournament : MonoBehaviour
{

    MotorbikeControllerTournament motorbikeControllerTournament;
    private void Awake()
    {
        motorbikeControllerTournament = GetComponent<MotorbikeControllerTournament>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        motorbikeControllerTournament.SetInputVector(input);
    }
}
