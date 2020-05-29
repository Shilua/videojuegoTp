using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerNivel2 : MonoBehaviour
{
    public int tiempoAAguantar;
    private TimeManager timeManager;
    public string nivel;

    void Awake()
    {
        GameObject manager = GameObject.Find("Manager");
        if (manager != null)
            timeManager = manager.GetComponent<TimeManager>();
    }

    void Update()
    {
        if(timeManager.timer >= tiempoAAguantar)
            SceneManager.LoadScene(nivel);
    }
}
