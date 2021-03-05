using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public CharacterController2D CharacterController;

    public Animator SpriteAnimator;

    public float Speed;

    private Vector3 RespawnPoint;

    //public GameObject GameOverScreen;
    private float _dir;
    private bool _doJump;
    
    public void SetInputs(float dirX, bool doJump)
    {
        _dir = dirX;
        _doJump = doJump;
    }

    private void Start()
    {
        RespawnPoint = this.gameObject.transform.position;
    }

    private void Update()
    {
        float vel = _dir * Speed;

        CharacterController.Move(vel, false, _doJump);

        //SpriteAnimator.SetBool("grounded", CharacterController.IsGrounded);
        //SpriteAnimator.SetBool("moving", vel != 0f);
        //SpriteAnimator.SetFloat("vel_y", CharacterController.Velocity.y);
    }

    public Vector3 GetRespawn()
    {
        return RespawnPoint;
    }
    public void SetRespawn(Vector3 newRespawn)
    {
        RespawnPoint = newRespawn;
    }
    void OnDestroy()
    {
        //GameOverScreen.SetActive(true);
    }
}
