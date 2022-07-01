using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionPlayer : MonoBehaviour

{
    public Estadisticas stad;
    public Transform camara;
    public Transform espacioArma;
    public Transform espacioCaja;
    public GameObject arma;
    public LayerMask lm;
    public float distanciaRayo;
    

    private void Update()
    {

        if (Input.GetButtonDown("coger"))
        {
            if (espacioCaja.childCount > 0)
            {
                espacioCaja.GetComponentInChildren<Rigidbody>().isKinematic = false;
                espacioCaja.DetachChildren();
                
                if (espacioArma.childCount > 0)
                {
                    espacioArma.GetChild(0).gameObject.SetActive(true);
                }
            }
            else
            {
                Debug.DrawRay(camara.position, camara.forward * distanciaRayo, Color.black);
                if(Physics.Raycast (camara.position, camara.forward, out RaycastHit hit, distanciaRayo, lm))
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.parent = espacioCaja;
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;

                    if (espacioArma.childCount > 0)
                    {
                        espacioArma.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "puerta" && stad.baterycont >=4)
        {
            other.GetComponentInParent<animacion>().OpenDoor();
        }
        if (other.tag == "bateria")
        {
            other.transform.GetComponent<Baterias>().Play();
            stad.baterycont++;

        }

        if (other.tag == "pistol")
        {

            arma.transform.parent = espacioArma;
            arma.transform.localPosition = Vector3.zero;
            arma.transform.localRotation  = Quaternion.Euler(0, 0, 0);
            if(espacioCaja.childCount > 0)
            {
                other.gameObject.SetActive(false);
            }
         
        }
    }
}
/* if(Input.GetButton("coger"))
          {
              hit.transform.parent = null;
          }
  
        if (Input.GetButtonDown("2"))
        {
            arma.parent = padreCaja;
            arma.localPosition = Vector3.zero;

padreCaja.GetComponentInChildren<Transform>().parent = null;

        }
if (espacio.childCount > 0)
            {
                other.gameObject.SetActive(false);
            }

11111
                if (espacio.childCount > 0)
                {
                    padreCaja.GetComponentInChildren<Rigidbody>().isKinematic = false;
                    padreCaja.GetChild(0).transform.parent = null;
                }
                else
                {
                    Debug.DrawRay(camara.position, camara.forward * 2, Color.black);
                    RaycastHit hit;
                    if (Physics.Raycast(camara.position, camara.forward, out hit, 3f, lm))
                    {

                        if (Input.GetButtonDown("coger"))
                        {
                            hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                            hit.transform.parent = padreCaja;
                            hit.transform.localPosition = Vector3.zero;
                            Debug.Log(hit.transform.name);
                        }
                        
                    }
         
                }
       
                if(espacio.childCount > 0)
                {
                    arma.gameObject.SetActive(false);
                }
                if (espacio.childCount == 0)
                {
                    arma.gameObject.SetActive(true);
                }
        */
