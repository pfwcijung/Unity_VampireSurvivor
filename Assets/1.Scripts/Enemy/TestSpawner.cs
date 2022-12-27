using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    [SerializeField] public Transform[] spawnPoint;

    int level;
    float spawnDelayTime = .5f;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }
    
    void Start()
    {
        SpawnStart();   
    }
    void SpawnStart()
    {
        InvokeRepeating("Spawn", 2f, spawnDelayTime);
    }
    void SpawnStop()
    {
        CancelInvoke("Spawn");
    }
    void Spawn()
    {
        level = Mathf.FloorToInt(GameManager.instance.gameTime / 60);
        GameObject enemy = GameManager.instance.spawn.Get(level);
        enemy.transform.position = spawnPoint[Random.Range(1, spawnPoint.Length)].transform.position;
        // 레벨이 적 집합 수보다 많을 경우 레벨 초기화 및 적군 스탯 증가
    }
}
