using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public struct EnemyData
{
    public int exp;
    public bool isLive;
    public float curHp;
    public float maxHp;
    public float speed;
    public Rigidbody2D rigid;
    public SpriteRenderer sprite;
}

public abstract class TestEnemy : MonoBehaviour
{
    public EnemyData ed = new EnemyData();
    public Rigidbody2D target;
    [SerializeField] public Player player;
    public float speed;
    public abstract void Initialize();
    public virtual void SetTarget()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody2D>();
        Debug.Log(target);
    }
    public virtual void Move()
    {
        Debug.Log(ed.speed);
        if (ed.speed == 0)
            return;
        if (ed.rigid == null)
            return;

        Vector2 dirVec = target.position - ed.rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        ed.rigid.MovePosition(ed.rigid.position + nextVec);
        ed.rigid.velocity = Vector2.zero;
        Debug.Log(ed.speed);
    }
    public virtual void SetRotation()
    {
        Debug.Log(ed.isLive);
        if (ed.isLive)
        {
            ed.sprite.flipX = target.position.x < ed.rigid.position.x;
        }
        else
            return;
    }

}
