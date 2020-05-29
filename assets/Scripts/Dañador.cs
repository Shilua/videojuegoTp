using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañador : MonoBehaviour
{
    public float daño;
    void OnTriggerEnter(Collider c)
    {

        Vida vidaDelObjeto = c.gameObject.GetComponent<Vida>();
        if(vidaDelObjeto != null)
        {
            vidaDelObjeto.cantidad -= daño;
            Destroy(this.gameObject);
        }
        
    }

   
}
