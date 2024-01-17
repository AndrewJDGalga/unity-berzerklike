using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PlayerMissile missileRef;
    [SerializeField] Transform missileSpawn;
    [SerializeField] float speed = 5.0f;
    Rigidbody2D _rb;
    Vector2 _moveDirection;
    Vector2 _missileDirection;

    Transform _moveShootUI;

    void Start(){
        _rb = GetComponent<Rigidbody2D>();
        _moveShootUI = transform.GetChild(0);
    }

    void FixedUpdate()
    {
        _rb.velocity = _moveDirection * speed;
        if(_moveDirection != Vector2.zero){
            _missileDirection = -_moveDirection; //missile opposite player
            float angle = Mathf.Atan2(_moveDirection.y, _moveDirection.x) * Mathf.Rad2Deg;
            _moveShootUI.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    void OnMove(InputValue val) {
        _moveDirection = val.Get<Vector2>();
    }
    void OnFire(InputValue val) {
        PlayerMissile missile = Instantiate(missileRef, missileSpawn.position, Quaternion.identity);
        missile.Direction = _missileDirection;
    }
}
