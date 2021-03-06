using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        Managers.Input.KeyAction -= onKeyBoard;
        Managers.Input.KeyAction += onKeyBoard;

        // 방향백터
        // // 1. 거리(크기) magnitude
        // // 2. 실제 방향

    }

    // GameObject (Player)
    // // Transform
    // // PlayerController (*)

    void Update()
    {

    }

    void onKeyBoard()
    {
        // 절대 회전값
        // transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);

        // +- detal
        // transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f));

        // transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));


        // transform.TransformDirection(): Local => World 
        // transform.InverseTransformDirection(): World => Local

        // transform.position.magnitude;
        // transform.position.normalized;

        if (Input.GetKey(KeyCode.W))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            // transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
