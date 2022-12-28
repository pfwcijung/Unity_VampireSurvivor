using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestPlayer : MonoBehaviour
{
    private float speed = 3f;
    public Vector2 inputVec;
    public HpController hp;

    float curHp = 100;
    float maxHp = 100;

    Animator anim;
    SpriteRenderer sprite;
    void Awake()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        inputVec.y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        transform.position += new Vector3(inputVec.x, inputVec.y, 0);
    }
    void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);
        if (inputVec.x != 0)
        {
            sprite.flipX = inputVec.x < 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy"))
        {
            Damage(.5f);
            GameManager.instance.killCount++;
            GameManager.instance.exp += 10;
        }
    }
    public void Damage(float damage)
    {
        curHp -= damage;
        hp.SetRenderSize(curHp, maxHp);
        if (curHp <= 0)
            Die();
    }
    void Die()
    {

    }
}
