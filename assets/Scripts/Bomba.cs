using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public string nombreAccion;
    public bool explotar;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(nombreAccion))
        {
            explotar = true;
        }

    }

    void Awake()
    {
        Invoke("explotarTrue", 2);
    }

    void OnTriggerStay(Collider c)
    {
        if (explotar)
        {
            Destroy(this.gameObject);
            Destroy(c.gameObject);
        }
    }

    void explotarTrue()
    {
        explotar = true;
    }
}
