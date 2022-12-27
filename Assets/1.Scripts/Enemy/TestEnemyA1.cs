using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyA1 : TestEnemy1
{   
    public override void Initialize()
    {
        ed1.exp = 10;
        ed1.isLive = true;
        ed1.curHp = 10f;
        ed1.maxHp = 10f;
        ed1.speed = 2f;
    }

    public override void SetTarget()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();
    }

    public override void Move()
    {
        base.Move();
    }
}
