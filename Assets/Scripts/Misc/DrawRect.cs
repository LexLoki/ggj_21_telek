using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRect : MonoBehaviour
{
    public Vector2 Size;

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, new Vector3(Size.x, Size.y, 1f));
    }
}
