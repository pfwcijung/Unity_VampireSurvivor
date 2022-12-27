using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public Transform[] spawnPoint;
    [SerializeField] public SpawnData[] spawnData;

    int level;
    float timer;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();    
    }

    void Update()
    {
        timer += Time.deltaTime;
        level = Mathf.FloorToInt(GameManager.instance.gameTime / 10);

        if (timer > (level == 0 ? .5f : .2f))
        {
            timer = 0;
            Spawn();
        }
    }
    void Spawn()
    {
        GameObject enemy = GameManager.instance.spawn.Get(level);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].transform.position;
    }
}

[System.Serializable]
public class SpawnData
{
    public int hp;
    public int spriteType;
    public float speed;
    public float spawnTime;
}
