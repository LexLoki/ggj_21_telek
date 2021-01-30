using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public CharacterController2D CharacterController;

    public float Speed;

    private float _dir;
    private bool _doJump;
    
    public void SetInputs(float dirX, bool doJump)
    {
        _dir = dirX;
        _doJump = doJump;
    }

    private void Update()
    {
        float vel = _dir * Speed;

        CharacterController.Move(vel, false, _doJump);
    }
}
