using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Vector3 PosAlvo;
    public float velocidade;
    
    private Vector3 PosIni;
    // Start is called before the first frame update
    void Start()
    {
        PosIni= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.LerpUnclamped(PosIni,PosAlvo,Mathf.Sin(Time.time * velocidade));
    }
}
