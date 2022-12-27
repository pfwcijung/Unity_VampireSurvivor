using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer hpRender;
    public void SetRenderSize(float curHp, float maxHp)
    {
        Vector2 size = new Vector2(curHp / maxHp, 1f);
        hpRender.transform.localScale = size;
    }
}
