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
            if(value != Vector2.zero) direction = value;
        }
        get => direction;
    }
    Vector2 direction;
    void Update() {

    }
}
