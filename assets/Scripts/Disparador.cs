using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string nombreAccion;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0, 0.5f);
        }

        if (Input.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        }
    }

    void Disparar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
