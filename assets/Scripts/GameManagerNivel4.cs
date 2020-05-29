using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerNivel4 : MonoBehaviour
{
    public int tiempoParaPerder;
    public int puntosGanados;
    public string nivel;
    public string otroNivel;
    private TimeManager timeManager;
    private ScoreManager scoreManager;


    void Awake()
    {
        GameObject manager = GameObject.Find("Manager");
        if (manager != null)
        {
            timeManager = manager.GetComponent<TimeManager>();
            scoreManager = manager.GetComponent<ScoreManager>();
        }

    }

    void Update()
    {
        if (scoreManager.score >= puntosGanados )
        {
            SceneManager.LoadScene(nivel);
        }else if (timeManager.timer >= tiempoParaPerder )
        {
            SceneManager.LoadScene(otroNivel);
        }
            
    }
}
