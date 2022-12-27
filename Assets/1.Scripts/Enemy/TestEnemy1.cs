using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
public struct EnemyData1
{
    public int exp;
    public bool isLive;
    public float curHp;
    public float maxHp;
    public float speed;
}
public abstract class TestEnemy1 : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer sprite;

    public Rigidbody2D target;
    public EnemyData1 ed1 = new EnemyData1();
    public abstract void Initialize();
    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public virtual void Move()
    {
        Vector2 dirVec = target.position - rigid.position;
        Vector2 nextVec = dirVec.normalized * ed1.speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        rigid.velocity = Vector2.zero;

        sprite.flipX = target.position.x < rigid.position.x;
    }
    public abstract void SetTarget();

    void Update() => Move();        
}
