using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidos : MonoBehaviour
{
    public AudioSource sorce;
    public AudioClip[] audiosFX;

 public void PlaySFX(int index,Vector3 desirePotion)
    {
        transform.position = desirePotion;
        sorce.PlayOneShot(audiosFX[index]);
    }

}
