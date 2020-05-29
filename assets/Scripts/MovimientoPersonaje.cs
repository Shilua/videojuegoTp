using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Arriba"))
        {
            movimiento(velocidadMovimiento);
        }else if(Input.GetButton("Abajo"))
        {
            movimiento(-velocidadMovimiento);
        }

        if (Input.GetButton("Izquierda"))
        {
            rotacion(-velocidadRotacion);
        }
        else if (Input.GetButton("Derecha"))
        {
            rotacion(velocidadRotacion);
        }
    }

    private void movimiento(float velocidad)
    {
        transform.Translate( 0, 0, velocidad * Time.deltaTime);
    }

    private void rotacion(float velocidad)
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}
