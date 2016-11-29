using UnityEngine;
using System.Collections;

public class GizmosExampleClass : MonoBehaviour {


    public Transform target;


    void OnDrawGizmos() {
        if (target != null) {
            Gizmos.color = Color.magenta;
            Gizmos.DrawLine(transform.position, target.position);
        }
    }
}