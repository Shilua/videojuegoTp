using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour
{
    public float bonus;
    void OnTriggerEnter(Collider c)
    {
        MovimientoPersonaje movimiento = c.gameObject.GetComponent<MovimientoPersonaje>();

        movimiento.velocidadMovimiento += bonus;
    }

    
}
