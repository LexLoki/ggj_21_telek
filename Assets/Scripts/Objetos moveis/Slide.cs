using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Vector3 PosAlvo;
    public float velocidade;
    
    private Vector3 PosIni;
    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        PosIni= transform.position;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2D.MovePosition(Vector3.LerpUnclamped(PosIni,PosAlvo,Mathf.Sin(Time.time * velocidade)));
    }
}
