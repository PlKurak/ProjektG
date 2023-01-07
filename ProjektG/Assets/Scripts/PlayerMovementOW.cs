using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovementOW : MonoBehaviour
{
    Inputs _inputs;
    InputAction move;
    [SerializeField] float dir;
    [SerializeField] float speed = 10f;
    void Awake()
    {
        _inputs = new Inputs();
    }
    private void OnEnable()
    {
        move = _inputs.PlayerOW.Movement;
        move.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }
    void Update()
    {
        dir = move.ReadValue<float>(); 
    }
    private void FixedUpdate()
    {
        doMove();
    }
    void doMove()
    {
        if(dir == 0){return;}
        Vector2 movementV = new Vector2(dir, 0);
        transform.Translate(movementV * Time.deltaTime * speed);
    }
}
