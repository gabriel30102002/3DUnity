using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPhysics : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del carro
    public float rotationSpeed = 100f; // Velocidad de rotación del carro

    // Update is called once per frame
    void Update()
    {
        // Movimiento hacia adelante automáticamente
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Rotación hacia la izquierda cuando se presiona la tecla 'Q'
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // Rotación hacia la derecha cuando se presiona la tecla 'R'
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        // Acelerar cuando se presiona la tecla 'W'
        if (Input.GetKey(KeyCode.W))
        {
            moveSpeed += 1f * Time.deltaTime; // Ajusta la velocidad de aceleración
        }

        // Frenar cuando se presiona la tecla 'S'
        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed -= 1f * Time.deltaTime; // Ajusta la velocidad de frenado
            // Asegúrate de que la velocidad no sea menor que cero
            moveSpeed = Mathf.Max(0f, moveSpeed);
        }
    }
}
