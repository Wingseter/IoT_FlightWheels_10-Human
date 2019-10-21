using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    //추적할 대상
    public Transform target;
  
    //카메라와의 거리
    public float dist = 0f;
    
    //카메라 초기 위치
    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        
        x = angles.y;
        y = angles.x;
    }

    // Update is called once per frame
    void Update()
    {
        ////카메라 회전속도 계산
        transform.rotation = Quaternion.Euler(target.eulerAngles);

        Vector3 position = target.position;
        
        transform.position = position;
    }
}
