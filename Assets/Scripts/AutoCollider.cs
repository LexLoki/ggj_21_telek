using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCollider : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
    {
        this.gameObject.AddComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
