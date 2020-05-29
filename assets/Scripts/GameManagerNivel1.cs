using System.Collections;
using System.Collections.Generic;
using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerNivel1 : MonoBehaviour
{
    private EnemyManager enemyManager;
    public int enemigosMuertos;
    public string nivel;

    void Awake()
    {
        GameObject manager = GameObject.Find("Manager");
        enemyManager = manager.GetComponent<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyManager.enemigosMuertos >= enemigosMuertos)
        {
            SceneManager.LoadScene(nivel);
        }
    }
}
