using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public Player player;
    [SerializeField] public SpawnManager spawn;
    [SerializeField] public float gameTime;
    [SerializeField] public float maxGameTime = 30 * 60f;
    void Awake() => instance = this;
    public int level { get; set; }
    public int killCount { get; set; }
    public int exp { get; set; }
    public int lvUpExp { get; set; }

    void Start()
    {
        level = 1;
        killCount = 0;
        exp = 0;
        lvUpExp = 100;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        if (gameTime > maxGameTime)
        {
            gameTime = maxGameTime;
        }

        if(exp >= lvUpExp)
        {
            //레벨 업 캔버스 활성화

            level++;
            exp = 0;
            lvUpExp *= 2;
        }
    }
}
