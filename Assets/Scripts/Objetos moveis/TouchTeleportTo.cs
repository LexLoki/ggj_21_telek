using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTeleportTo : MonoBehaviour
{
    public Vector3 destino;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if(other.tag != "Botao")
        if (other.collider.tag == "Player")
        {
            other.gameObject.transform.position = destino;
        }
        
    }

}
