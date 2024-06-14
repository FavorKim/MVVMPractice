using UnityEngine;

public class ChangeNameBtn : MonoBehaviour
{
    public void OnClick_RequestChangeName()
    {
        GameLogicManager.Inst.RequestChangeName("º¯°æ");
    }
}
