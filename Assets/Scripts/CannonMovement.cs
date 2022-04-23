using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CannonMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(-Vector3.forward * Time.deltaTime * _speed);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.forward * Time.deltaTime * _speed);
        }


        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left * Time.deltaTime * _speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right * Time.deltaTime * _speed);
        }
    }
}
