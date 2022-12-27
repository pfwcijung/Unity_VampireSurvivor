using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILvUpController : MonoBehaviour
{
    [SerializeField] private List<Button> buttons;
    void Start()
    {
        buttons[0].onClick.AddListener(() => OnChooseSkill(0));
        buttons[1].onClick.AddListener(() => OnChooseSkill(1));
        buttons[2].onClick.AddListener(() => OnChooseSkill(2));
    }
    public void OnChooseSkill(int chooseIndex)
    {
        //스킬 레벨 상승
    }

}
