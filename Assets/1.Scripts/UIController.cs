using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text killTxt;
    [SerializeField] private TMP_Text timeTxt;
    [SerializeField] private TMP_Text levelTxt;
    [SerializeField] private Image expGage;

    float min, sec;
    float curExp, MaxExp;

    void Update()
    {
        min = (int)GameManager.instance.gameTime / 60;
        sec = (int)GameManager.instance.gameTime % 60;
        curExp = (int)GameManager.instance.exp;
        MaxExp = (int)GameManager.instance.lvUpExp;

        killTxt.text = $"{GameManager.instance.killCount}";
        timeTxt.text = string.Format($"{min:00}:{sec:00}");
        levelTxt.text = $"Lv.{GameManager.instance.level}";

        expGage.fillAmount = curExp / MaxExp;
    }
}
