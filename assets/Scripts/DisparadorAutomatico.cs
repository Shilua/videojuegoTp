using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Awake()
    {
        InvokeRepeating("Disparar", 0, 10f);
    }

    void Disparar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
