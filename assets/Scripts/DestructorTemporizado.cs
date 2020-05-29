using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
 
    void Awake()
    {
        Invoke("Destruir", 3);
    }

    void Destruir()
    {
        Destroy(this.gameObject);
    }
}
