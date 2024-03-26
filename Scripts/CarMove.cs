using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del carro

    // Update is called once per frame
    void Update()
    {
        // Mover hacia adelante automáticamente
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // Mover hacia la izquierda cuando se presiona la tecla 'A'
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
        // Mover hacia la derecha cuando se presiona la tecla 'D'
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
