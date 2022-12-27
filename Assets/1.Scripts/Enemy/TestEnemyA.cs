using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyA : TestEnemy
{ 
    Rigidbody2D rigid;
    SpriteRenderer sprite;
    public override void Initialize()
    {
        ed.exp = 10;
        ed.isLive = true;
        ed.curHp = 10f;
        ed.maxHp = 10f;
        ed.speed = 2f;
        ed.rigid = rigid;
        ed.sprite = sprite;
    }
    public override void SetTarget()
    {
        base.SetTarget();
    }

    public override void Move()
    {
        base.Move();
    }
   
    public override void SetRotation()
    {
        base.SetRotation();
    }

}
