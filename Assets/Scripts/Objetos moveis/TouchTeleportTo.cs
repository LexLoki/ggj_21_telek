using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTeleportTo : MonoBehaviour
{
    public Vector3 destino;
    public bool isKill = false;
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
            Debug.Log("Player tocou em tp");
            if (isKill)
            {
                //pega checkpoint como destino
                //other.gameObject.transform.position = checkpoint;
            }
            else
            {
                other.gameObject.transform.position = destino;
            }
        }

        
    }

}
