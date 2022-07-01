using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    public GameObject pref_B;
    public Transform spawnPoint;
    public float fuerza;
  //instanciar un objeto
  //fuerza al ridgibody
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(pref_B, spawnPoint.position, spawnPoint.rotation);
            go.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*fuerza, ForceMode.Impulse);
            
        }
    }
}
