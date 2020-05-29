using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerNivel3 : MonoBehaviour
{
    public int tiempoAAguantar;
    public int enemigosMuertos;
    public string nivel;
    private TimeManager timeManager;
    private EnemyManager enemyManager;
    

    void Awake()
    {
        GameObject manager = GameObject.Find("Manager");
        if (manager != null)
        {
            timeManager = manager.GetComponent<TimeManager>();
            enemyManager = manager.GetComponent<EnemyManager>();
        }
            
    }

    void Update()
    {
        if (
            timeManager.timer >= tiempoAAguantar 
            || enemyManager.enemigosMuertos >= enemigosMuertos
            )
            SceneManager.LoadScene(nivel);
    }
}
