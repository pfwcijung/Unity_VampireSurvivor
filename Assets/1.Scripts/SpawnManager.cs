using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    List<GameObject>[] spawns;

    void Awake()
    {
        spawns = new List<GameObject>[enemies.Length];
        for(int i = 0; i < spawns.Length; i++)
        {
            spawns[i] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;

        foreach(var items in spawns[index])
        {
            if (!items.activeSelf)
            {
                select = items;
                select.SetActive(true);
                break;
            }
        }

        if (!select)
        {
            select = Instantiate(enemies[index], transform);
            spawns[index].Add(select);
        }

        return select;
    }
}
