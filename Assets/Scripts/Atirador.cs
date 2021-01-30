using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirador : MonoBehaviour
{
    public GameObject projetil;
    public float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EsperaTiro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EsperaTiro()
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(projetil,transform.position,Quaternion.identity);
        StartCoroutine(EsperaTiro());
    }
}
