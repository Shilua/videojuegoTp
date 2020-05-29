using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleadas : MonoBehaviour
{
    public GameObject prefab;
    void Awake()
    {
        InvokeRepeating("generar", 0, 10f);
    }

    void generar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
