using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public float rotationSpeed = 60f;

    void Update() {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            rotationSpeed = rotationSpeed * -1;
        }
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}