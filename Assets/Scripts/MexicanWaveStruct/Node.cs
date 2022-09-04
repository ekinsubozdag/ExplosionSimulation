using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Node : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.2f);
    }
}
