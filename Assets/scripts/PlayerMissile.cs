using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMissile : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    public Vector2 Direction {
        set {
            if(value != Vector2.zero) _direction = value;
        }
        get => _direction;
    }
    Vector2 _direction;
    Rigidbody2D _rb;

    void Start() {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        _rb.velocity = Direction * moveSpeed;
    }
}
