using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            Debug.Log("Spawnpoint Set");
            other.gameObject.GetComponent<PlayerBehaviour>().SetRespawn(this.gameObject.transform.parent.gameObject.transform.position);
            
        }
    }

}
