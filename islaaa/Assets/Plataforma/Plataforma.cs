using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject plataforma;
   

    public Transform minpos;
    public Transform maxpos;
    public float speed = 10;

    private void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
            MovePlataform();
        }
    }
    private void MovePlataform()
    {
        plataforma.transform.Translate(Vector3.up * Time.deltaTime * speed);


       if( plataforma.transform.position.y >= maxpos.position.y)
        {
            speed = -7f;

        }   
       if(plataforma.transform.position.y <= minpos.position.y)
        {
            speed = 7;
        }
       
    }
}

//Plataforma maxpos down
