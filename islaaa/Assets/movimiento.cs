using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [Header("movimiento")]
    public float speedMovement;
    public int caminar, correr, saltar;
    public Vector3 direccion;
    public CharacterController controller;
    public Vector3 desplazamientoY;


    [Header("Jump")]
    public Vector3 movimientoY;
    public float jumpHeight;
    public float gravity = -9.8f;



    [Header("rotacion")]
    public Vector2 mouseMovement;
    public float rotacionPlayerY;
    public float rotacionCamaraX;
    public Camera playerCamara;
    // Update is called once per frame
    public void Update()
    {
        //movimiento del mouse
        mouseMovement.x = Input.GetAxis("Mouse X");
        mouseMovement.y = Input.GetAxis("Mouse Y");

        //movimiento personaje
        direccion.z = Input.GetAxis("Vertical");
        direccion.x = Input.GetAxis("Horizontal");

        direccion = transform.TransformDirection(direccion);

        controller.Move(direccion * Time.deltaTime * speedMovement);


        //salto 2
        movimientoY.y += gravity * Time.deltaTime;
        controller.Move(movimientoY * Time.deltaTime);

        if (controller.isGrounded && movimientoY.y < 0)
        {
            movimientoY.y = -2f;
        }
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            movimientoY.y = Mathf.Sqrt(jumpHeight * -2F * gravity);

        }

        //movimiento de la camara
        rotacionCamaraX -= mouseMovement.y;
        rotacionPlayerY += mouseMovement.x;

    }
    public void Accion(float vertical, float horizontal)
    {
        mouseMovement.x = horizontal;
        mouseMovement.y = vertical;
    }
    public void Giro(float valorGiro)
    {
        rotacionPlayerY += valorGiro;
        //rotacion del personaje
        controller.transform.rotation = Quaternion.Euler(0, rotacionPlayerY, 0);


    }
    public void Movimiento(float vertical, float horizontal)
    {
        direccion.x = horizontal;
        direccion.z = vertical;

        direccion = transform.TransformDirection(direccion);
        controller.Move(direccion * Time.deltaTime * speedMovement);
    }

}


/*
if (rotacionCamaraX >= 40)
{
    rotacionCamaraX = 40;
}
if (rotacionCamaraX <= -40)
{
    rotacionCamaraX = -40;

}
*/

/*
if(controller.isGrounded && direccion.y < 0)
{
    direccion.y = -2f;
}
if (controller.isGrounded && Input.GetButton("Jump"))
{
    direccion.y = Mathf.Sqrt(jumpHeight * -2F * gravity);

}
*/

