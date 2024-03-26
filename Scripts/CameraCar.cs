using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCar : MonoBehaviour
{
     public Transform target; // Referencia al transform del carro
    public Vector3 offset;   // Distancia de desplazamiento de la cámara respecto al carro
    public bool rotateWithCar = true; // Variable para determinar si la cámara debe rotar con el carro

    private Vector3 initialOffset; // Offset inicial

    void Start()
    {
        // Calcula el offset inicial como la diferencia entre la posición de la cámara y la posición del carro
        initialOffset = transform.position - target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            // Establecer la posición de la cámara como la posición del carro más el offset
            transform.position = target.position + offset;

            // Si rotateWithCar es verdadero, ajusta la rotación de la cámara para que coincida con la rotación del carro
            if (rotateWithCar)
            {
                transform.rotation = target.rotation;
            }
            else
            {
                // Asegurarse de que la cámara mire hacia el carro
                transform.LookAt(target);
            }
        }
    }
}
