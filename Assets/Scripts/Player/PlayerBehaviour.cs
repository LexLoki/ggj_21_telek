using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public CharacterController2D CharacterController;

    public Animator SpriteAnimator;

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

        SpriteAnimator.SetBool("grounded", CharacterController.IsGrounded);
        SpriteAnimator.SetBool("moving", vel != 0f);
        SpriteAnimator.SetFloat("vel_y", CharacterController.Velocity.y);
    }
}
