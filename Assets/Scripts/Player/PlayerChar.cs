using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerChar : Singleton<PlayerChar>
{
    [SerializeField] private PlayerControls controls;   //unity input system
    private Rigidbody rb;
    
    private Vector2 dirInput;   //direcao que o player esta segurando

    public PlayerStateBase currentState;

    
    private void Awake() 
    {
        //referencia de componentes
        rb = GetComponent<Rigidbody>();

        //atribuicao das acoes
        controls.PlayerMovement.MoveDir.performed += _ => UpdateDirection(_.ReadValue<Vector2>());
    }

    //atualiza a direcao de movimento desejada
    private void UpdateDirection(Vector2 v)
    {
        dirInput = v;
    }

    private void FixedUpdate() 
    {
        
    }
}
