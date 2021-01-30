using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{

    public float velocidadeMovIni;
    public float velocidadeRot;
    public float accel;

    private float currentVelMov;
    //public gameobject player;

    void Start()
    {
        //transform.LookAt(player)
        currentVelMov = velocidadeMovIni;
    }

    void Update()
    {
        transform.Translate(0,currentVelMov * Time.deltaTime,0, Space.Self);
        
        
        if (Input.GetKey("z") || Input.GetKey("left"))
        {
            transform.Rotate(0,0,1 * velocidadeRot);
        }
        if (Input.GetKey("x") || Input.GetKey("right"))
        {
            transform.Rotate(0,0,-1 * velocidadeRot);
        }

        currentVelMov += accel;
    }
}
