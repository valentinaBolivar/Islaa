using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MoventControoller))]
public class IA : MonoBehaviour
{
    public MoventControoller movent;
    public Transform jugador;
    public float rango = 15f;
    public GameObject enemy;
    
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, jugador.position);
        if(distance <= rango)
        {
            Vector3 forward = transform.transform.TransformDirection(Vector3.forward);
            Vector3 toOther = jugador.position - transform.position;

            forward = forward.normalized;
            toOther = toOther.normalized;

            if(Vector3.Dot(toOther,forward) < 0.99)
            {
                if (Vector3.Dot(forward, toOther) <= 0.99f)
                {
                    movent.Rotate(1);
                }
                else
                {
                    movent.Rotate(-1);
                }
            }
        }
    }
}
