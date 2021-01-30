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

    public TipoControle modoControle;

    private float currentVelMov;
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool isDraged;

    private Vector3 PosAnterior;
    //public gameobject player;

    void Start()
    {
        //transform.LookAt(player)
        currentVelMov = velocidadeMovIni;
        
        PosAnterior = transform.position;

        isDraged = false;
    }

    void Update()
    {
        //andar para frente se não estiver arrastado
        if (!isDraged)
        {
            transform.Translate(0,currentVelMov * Time.deltaTime,0, Space.Self);
        }
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

        if (modoControle == TipoControle.Mouse)
        {
            if(PosAnterior != transform.position)
            {
                transform.right = Vector3.LerpUnclamped(PosAnterior - transform.position,transform.position - PosAnterior, 0.01f);
                transform.Rotate(0,0,90);
            }
        }
        PosAnterior = transform.position;
            
        //aceleração    
        currentVelMov += accel;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Destruiu");
        Destroy(gameObject);
    }


    //girar puxando com mouse
    void OnMouseDown() {
        if (modoControle == TipoControle.Mouse)
        {
            isDraged = true;
            Physics.queriesHitTriggers = true;
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }

    void OnMouseDrag()
    {
        isDraged = true;
        if (modoControle == TipoControle.Mouse)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            if (gameObject != null)
            {
                transform.position = curPosition;
            }
        }
    }

    void OnMouseUp()
    {
        isDraged = false;
    }
}
