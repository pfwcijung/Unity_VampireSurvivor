using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public Player player;
    [SerializeField] public SpawnManager spawn;
    public float gameTime;
    private float maxGameTime = 30 * 60f;

    void Awake()
    {
        instance = this;   
    }
    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }
    }
}
