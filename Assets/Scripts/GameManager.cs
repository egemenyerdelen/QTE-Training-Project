using System;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int score = 0;
    public int remainLife = 3;
    public bool canSuperEnable;
    public bool isSuperActive;
    public bool isObjectInSaveDistance = false;
    public bool isGameOver;


    public void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        GameOver();
    }

    public void GameOver()
    {
        if (remainLife <= 0)
        {
            isGameOver = true;
            UI.Instance.OpenGameOverPanel();
            Time.timeScale = 0;
        }
    }
}
