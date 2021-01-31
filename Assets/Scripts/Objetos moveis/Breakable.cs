using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public int health = 1;
    // Start is called before the first frame update
    
    void OnCollisionEnter2D(Collision2D outro)
    {
        if(outro.collider.tag == "Projetil")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
