using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TempProfile.Extension;

public class TempProfileUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    private TempProfileUIViewModel vm;

    private void OnEnable()
    {
        if(vm == null)
        {
            vm = new TempProfileUIViewModel();
            vm.PropertyChanged += OnPlayerNameChanged;
            vm.RegisterOnEnable();
            vm.RefreshTempProfileUI();
        }
    }

    private void OnDisable()
    {
        if(vm != null)
        {
            vm.UnregisterOnDisable();
            vm.PropertyChanged -= OnPlayerNameChanged;
            vm = null;
        }
    }

    private void OnPlayerNameChanged(object sender, PropertyChangedEventArgs e)
    {
        switch(e.PropertyName)
        {
            case nameof(vm.PlayerName):
                Text_Name.text = vm.PlayerName;
                break;
        }
    }
}
