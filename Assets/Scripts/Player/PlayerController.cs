using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public PlayerBehaviour Player;

    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode JumpKey;

    // Update is called once per frame
    void Update()
    {
        float dir = 0f;
        if (Input.GetKey(LeftKey))
        {
            dir = -1f;
        }
        else if(Input.GetKey(RightKey))
        {
            dir = 1f;
        }

        Player.SetInputs(dir, Input.GetKeyDown(JumpKey));

    }
}
