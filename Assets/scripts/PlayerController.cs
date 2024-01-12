using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    Rigidbody2D _rb;
    Vector2 _moveDirection;

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.velocity = _moveDirection * speed;
    }

    void OnMove(InputValue val) {
        _moveDirection = val.Get<Vector2>();
    }
}
