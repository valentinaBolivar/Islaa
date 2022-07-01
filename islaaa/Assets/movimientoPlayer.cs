using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlayer : MonoBehaviour
{
    //movimiento personaje
    public float speedMovement;
    public Vector3 direccion;
    public CharacterController controller;

    //gravedad
    public float jumpHeight;
    public float gravity = -9.8f;
    public Vector3 desplazamientoY;

    //rotacion
    public float RotacionPlayeRY;
    public float rotacionPlayerY;

    void Update()
    {
        //CALCULAR GRAVEDAD CADA FRAME
        desplazamientoY.y += gravity * 2f * Time.deltaTime;

        //MOVIMIENTO PLAYER EN Y
        controller.Move(desplazamientoY * Time.deltaTime);

        //EN EL SUELO  EN VALOR DE "y" ES NEGATIVO -GRAVEDAD
        if (controller.isGrounded && desplazamientoY.y < 0)
        {
            desplazamientoY.y = -2f;
        }

        //salto
        if(controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            desplazamientoY.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    public void move(float Vertical, float Horizontal)
    {
        //ENEMIGO MOVIMIENTO
        direccion.x = Horizontal;
        direccion.y = Vertical;

        //COORDENADAS DEL JUGADOR
        direccion = transform.TransformDirection(direccion);

        //MOVER JUGADOR CON TECLAS
        controller.transform.rotation = Quaternion.Euler(0, RotacionPlayeRY, 0);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Rotate(float rotateValue)
    {

        RotacionPlayeRY += rotateValue;

        //rotar el personaje en base al movimiento acumulaod 
        controller.transform.rotation = Quaternion.Euler(0, RotacionPlayeRY, 0);

    }
}
