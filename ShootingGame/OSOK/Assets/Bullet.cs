using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Destroy(Object obj, float t)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        // 게임 오브젝트 중에서 Rigidbody 넣어
        bulletRigidbody = GetComponent<Rigidbody>();
        // Rigidbody 속도  =  방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
