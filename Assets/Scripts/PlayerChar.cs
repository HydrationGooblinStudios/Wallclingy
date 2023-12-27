using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerChar : MonoBehaviour
{
    [SerializeField] private PlayerControls controls;
    private Vector3 moveDir;
    
    private void Awake() {
        controls.PlayerMovement.MoveDir.performed += _ => MovementUpdate(_.ReadValue<Vector2>());
    }

    private void MovementUpdate(Vector2 v)
    {
        moveDir = v;
    }
}
