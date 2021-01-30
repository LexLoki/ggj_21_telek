using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public enum TipoControle
    {
        Mouse,
        Teclado,
        Random
    }

    public float velocidadeMovIni;
    public float velocidadeRot;
    public float accel;

    private float currentVelMov;

    public TipoControle modoControle;
    //public gameobject player;

    void Start()
    {
        //transform.LookAt(player)
        currentVelMov = velocidadeMovIni;
    }

    void Update()
    {
        //andar para frente
        transform.Translate(0,currentVelMov * Time.deltaTime,0, Space.Self);
        
        //girar por teclado
        if (modoControle == TipoControle.Teclado)
        {
            if (Input.GetKey("z") || Input.GetKey("left"))
            {
                transform.Rotate(0,0,1 * velocidadeRot);
            }
            if (Input.GetKey("x") || Input.GetKey("right"))
            {
                transform.Rotate(0,0,-1 * velocidadeRot);
            }
        }

        //girar aleatoriamente por mouse
        if (modoControle == TipoControle.Random)
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
                if (hit.collider != null) 
                {
                    Debug.Log(hit.collider.gameObject.name);
                    hit.collider.attachedRigidbody.transform.Rotate(0,0,Random.Range(0,360));
             }
            }
        }
            
        //aceleração    
        currentVelMov += accel;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Destruiu");
        Destroy(gameObject);
    }
    public void setModoControle(TipoControle novoModo)
    {
        modoControle = novoModo;
    }
}
