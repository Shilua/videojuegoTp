using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float cantidad;

    // Update is called once per frame
    void Update()
    {
        if(cantidad <= 0){
            SendMessage("Mori");
            Destroy(this.gameObject);
        }
    }
}
