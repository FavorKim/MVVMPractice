using System.Collections.Generic;
using UnityEngine;

public class ChangeNameBtn : MonoBehaviour
{
    List<string> names = new List<string>
    {
        "�ⷯ��", "�ξ���", "������", "��½��", "���ڱ���", "������", "��ѱ�", "�ְ���"
    };
    public void OnClick_RequestChangeName()
    {
        int index = 0;
        index = Random.Range(0, names.Count);
        GameLogicManager.Inst.RequestChangeName(names[index]);
    }
}
