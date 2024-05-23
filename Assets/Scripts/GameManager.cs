using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int score = 0;
    public int remainLife = 3;
    public float saveDistance;

    public void Awake()
    {
        Instance = this;
    }
}
