using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public float velocidade;
    public Vector3 destino;
    public bool AtivadoPorToque;
    private bool ativo;
    // Start is called before the first frame update
    void Start()
    {
        if (AtivadoPorToque)
        {
            ativo = false;
        }
        else ativo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ativo)
        {
            transform.position = Vector3.MoveTowards(transform.position,destino,velocidade * Time.deltaTime);

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if(other.tag != "Botao")
        if (other.collider.tag == "Player")
        {
            ativo = true;
        }
    }

    
}
