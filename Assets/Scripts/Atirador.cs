using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirador : MonoBehaviour
{
    public GameObject projetil;
    public float intervalo;
    public Vector3 rotacaoProjetil;
    public float velocidadeProjetil = 3;
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
        GameObject projectile = Instantiate(projetil,transform.position,Quaternion.Euler(rotacaoProjetil.x,rotacaoProjetil.y,rotacaoProjetil.z));
    	projectile.GetComponent<Projetil>().velocidadeMovIni = velocidadeProjetil;        

        StartCoroutine(EsperaTiro());
    }
}
