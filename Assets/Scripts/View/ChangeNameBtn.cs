using System.Collections.Generic;
using UnityEngine;

public class ChangeNameBtn : MonoBehaviour
{
    List<string> names = new List<string>
    {
        "기러기", "부엉이", "따오기", "소쩍새", "직박구리", "오목눈이", "비둘기", "왜가리"
    };
    public void OnClick_RequestChangeName()
    {
        int index = 0;
        index = Random.Range(0, names.Count);
        GameLogicManager.Inst.RequestChangeName(names[index]);
    }
}
