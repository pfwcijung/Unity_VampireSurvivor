using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 playerPos;

    void Update()
    {
        playerPos = GameManager.instance.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y, -10f);
    }
}
