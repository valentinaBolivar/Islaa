using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entro al trigger");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("esta en el trigger");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Salio del trigger");
    }
}
