using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerLeague : MonoBehaviour
{

    MotorbikeControllerLeague motorbikeControllerLeague;
    private void Awake()
    {
        motorbikeControllerLeague = GetComponent<MotorbikeControllerLeague>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        motorbikeControllerLeague.SetInputVector(input);
    }
}
