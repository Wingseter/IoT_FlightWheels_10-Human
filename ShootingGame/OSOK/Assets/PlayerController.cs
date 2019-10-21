using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xRotSpeed;    // x 축 회전 속도
    private float yRotSpeed;    // y 축 회전 속도
    private float xAngle;   // x 축 각도
    private float yAngle;   // y 축 각도
    private Quaternion newRotaion;   // 사용자가 이동하고 있는 각도
    public Rigidbody playerRigidbody;   // 이동에 사용할 리지드 바디 컴포넌트
    public float MovementSpeed = 0f;    // 이동 속력

    // Start is called before the first frame update
    void Start()
    {
        // 게임 오브젝트에서 playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
        xAngle = 0f;
        yAngle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Vertical");
        float yInput = Input.GetAxis("Horizontal") / 10f;
        bool booster = Input.GetButtonDown("Jump");

        // 실제 이동 속도를 입력값가 이동 속력을 사용해 결정
        if(xInput == 0)
        {
            xRotSpeed = 0f;
        }
        else
        {
            xRotSpeed = 2f;
        }

        if(yInput == 0)
        {
            yRotSpeed = 0f;
        }
        else
        {
            yRotSpeed = 8f;
        }
        // Vector3 속도를 (xSpeed, 0, zSpeed)로 결정
        transform.Rotate(xInput * xRotSpeed, 0, yInput * yRotSpeed);

        if(booster == true)
        {
            MovementSpeed = 8f;
        }
        else
        {
            MovementSpeed = 1f;
        }
        transform.position += transform.forward * MovementSpeed * Time.deltaTime;
    }
}
