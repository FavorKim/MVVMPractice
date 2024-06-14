using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using TempProfile.Extension;
using ViewModel.Extensions;


public class TempProfileUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;
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
            case nameof(vm.Name):
                Text_Name.text = $"이름 : {vm.Name}";
                break;
            case nameof(vm.Level):
                Text_Level.text = $"레벨 : {vm.Level}";
                break;
        }
    }
}
