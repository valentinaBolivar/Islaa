using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baterias : MonoBehaviour
{
    public AudioSource sorce;
    public AudioClip audiosFX;
    public float volumen;

    public void Play()
    {
        gameObject.SetActive(false);
        sorce.transform.position = transform.position;
        sorce.PlayOneShot(audiosFX, volumen);
    }
    public void PlaySFX(int index, Vector3 desirePotion)
    {
        transform.position = desirePotion;
        
    }

}
    

      
    

