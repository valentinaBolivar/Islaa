using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public Animator anim;
    public void OpenDoor()
    {
        anim.SetTrigger("New Trigger");
    }

}
