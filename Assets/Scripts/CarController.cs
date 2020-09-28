using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL="Horizontal";
    private const string VERTICAL="Vertical";
    private float horizontalInput;
    private float verticalInput;
    private bool isBreaking;
    private void FixedUpdate()
    {
        GetInput();
        HandledMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GeiInput(){
        horizontalInput=Input.GetAxis(HORIZONTAL);
        verticalInput=Input.GetAxis(VERTICAL);
        isBreaking=Input.GetAxis(KeyCode.Space);
    }
}
